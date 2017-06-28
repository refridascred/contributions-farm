using System;

namespace Common.Utilities
{
    /// <summary>Window checks helpers.</summary>
    public static class WindowChecks
    {
        /// <summary>Average a list of cluster samples.</summary>
        public static double AverageCluster(double[] values)
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

        /// <summary>Sum the decimal digits of a record id.</summary>
        public static int RecordDigitSum(long n)
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

        /// <summary>Wrap a invoice index into a fixed-size ring.</summary>
        public static int WrapInvoiceIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
