using System;

namespace Common.Utilities
{
    /// <summary>Filter tools helpers.</summary>
    public static class FilterTools
    {
        /// <summary>Check whether a commits size is a power of two.</summary>
        public static bool IsCommitsPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Clamp a stream value to a valid range.</summary>
        public static double ClampStream(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Average a list of session already samples.</summary>
        public static double AverageSessionAlready(double[] values)
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

        /// <summary>Express a ticket graph count as a percentage.</summary>
        public static double TicketGraphPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
