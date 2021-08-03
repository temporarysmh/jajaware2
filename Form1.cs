using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/fpCqG4k4En");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sellix.io/product/6109be871644f");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged, if it is a fake key you won't get your whitelist.");
        }
    }
}
