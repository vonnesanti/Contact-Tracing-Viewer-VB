Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Filter = "C:\Users\fujjitsu\source\repos\Contact Tracing Form | *.txt"

        If ofd.ShowDialog() = DialogResult.OK Then
            infoTxtbx.Text = File.ReadAllText(ofd.FileName)
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        infoTxtbx.Clear()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim GameExit As DialogResult = MessageBox.Show("Are you sure you want to exit?", "CONTACT TRACING VIEWER", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If GameExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
