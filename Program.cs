using System.Globalization;

//Nokta Atış Yaş Hesaplayıcı.
Console.WriteLine("Doğum tarihinizi girin.(GG/AA/YYYY): ");
DateTime dogumTarihi = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));
DateTime bugun = DateTime.Today;
TimeSpan fark = bugun - dogumTarihi;//bugun.subtract
double yas= fark.TotalHours / (365 *24 +6);
Console.WriteLine("Yaşınız: "+ (int)yas);
