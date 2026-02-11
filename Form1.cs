namespace hafta5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydet tuþuna basýldý");

            double sayi, kupu;
            sayi = Convert.ToDouble(textBox1.Text);
            kupu = sayi * sayi * sayi;

            MessageBox.Show("Sayýnýn küpü: " + kupu);
            label1.Text= Convert.ToString(kupu);
        }
    }
}
