using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5hub
{
    public partial class Form1 : Form
    { 
        public Form1()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int clicks = 0;
            int until = 20 - clicks;
            string yet = until.ToString();
            if (clicks == 20)
            {
                devops.Visible = true;
                clickc.Text = "Test APP";
            } else
            {
                clicks++;
            }

            if (clicks <= 19) {
                if (clicks >= 5)
                {
                    clickc.Text = yet;
                }
            } else
            {
                clickc.Text = "TestAPP";
            }
        }
    }
}
