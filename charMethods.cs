using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharMethods
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = AnalyzeCharacter(char.Parse(txtInputChar.Text));
                txtInputChar.SelectAll();
                txtInputChar.Focus();
            }
            catch (FormatException)
            {

                MessageBox.Show("You may supply only a single character.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInputChar.SelectAll();
                txtInputChar.Focus();
            }
        }

        private string AnalyzeCharacter(char chInput)
        {
            string strOutput;

            strOutput = "is digit: " +
               Char.IsDigit(chInput) + "\r\n";

            strOutput += "is letter: " +
               Char.IsLetter(chInput) + "\r\n";

            strOutput += "is letter or digit: " +
               Char.IsLetterOrDigit(chInput) + "\r\n";

            strOutput += "is lower case: " +
               Char.IsLower(chInput) + "\r\n";

            strOutput += "is upper case: " +
               Char.IsUpper(chInput) + "\r\n";

            strOutput += "to upper case: " +
               Char.ToUpper(chInput) + "\r\n";

            strOutput += "to lower case: " +
               Char.ToLower(chInput) + "\r\n";

            strOutput += "is punctuation: " +
               Char.IsPunctuation(chInput) + "\r\n";

            strOutput += "is symbol: " + Char.IsSymbol(chInput);

            return strOutput;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtInputChar.Clear();
            txtInputChar.Focus();
        }
    }
}
