using System;

namespace Common.Utilities
{
    /// <summary>Editor format helpers.</summary>
    public static class EditorFormat
    {
        /// <summary>Average a list of entry digest samples.</summary>
        public static double AverageEntryDigest(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
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
