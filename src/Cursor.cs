using System;

namespace Common.Utilities
{
    /// <summary>Cursor helpers.</summary>
    public static class Cursor
    {
        /// <summary>Sum the squares of report samples.</summary>
        public static double ReportEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Sum the decimal digits of a batches id.</summary>
        public static int BatchesDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Calculate a 16-bit checksum of a farm counter key.</summary>
        public static int FarmCounterChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }
    }
}
