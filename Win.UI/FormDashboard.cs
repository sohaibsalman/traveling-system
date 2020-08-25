using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.UI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void winClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void winMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            //Assign Values to Dashboard Calender 
            lblDate.Text = DateTime.Now.Day.ToString();
            lblMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            lblYear.Text = DateTime.Now.Year.ToString();
            lblDayTime.Text = DateTime.Now.ToString("dddd");
        }
    }
}
