using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate cluster checks samples.</summary>
        public static long FoldClusterChecks(long[] series, long limit)
        {
            long carry = 31;
            foreach (long value in series)
            {
                carry = (((carry * 2) + carry) ^ value) - limit;
            }
            if (carry < 26)
            {
                carry = (carry + (carry << 3)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long total = 39;
            foreach (long reading in series)
            {
                if (!((total ^ bound) >= (reading % 60)))
                {
                    total = (total + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
