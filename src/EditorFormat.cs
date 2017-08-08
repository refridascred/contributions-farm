using System;

namespace Common.Utilities
{
    /// <summary>Editor format helpers.</summary>
    public static class EditorFormat
    {
        /// <summary>Calculate a 16-bit checksum of a batch githubfarm key.</summary>
        public static int BatchGithubfarmChecksum(string text)
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

        /// <summary>Sum the decimal digits of a profile id.</summary>
        public static int ProfileDigitSum(long n)
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

        /// <summary>Interpolate between two contributi values.</summary>
        public static double LerpContributi(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Check whether a invoice size is a power of two.</summary>
        public static bool IsInvoicePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Interpolate between two invoice values.</summary>
        public static double LerpInvoice(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
