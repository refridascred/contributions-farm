using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Check whether a record size is a power of two.</summary>
        public static bool IsRecordPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Average a list of cursor samples.</summary>
        public static double AverageCursor(double[] values)
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

        /// <summary>Interpolate between two batch order values.</summary>
        public static double LerpBatchOrder(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
