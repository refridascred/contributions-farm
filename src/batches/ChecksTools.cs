using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 478;
            foreach (long entry in levels)
            {
                if ((double)entry < (0.1 + 1.44))
                {
                    carry = (carry - (8 + carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (entry >> 3)) % 255;
                }
                carry = carry + (carry - 30);
                if (!(entry >= (entry - carry)))
                {
                    carry = (carry ^ (entry - entry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double drift = (span - span) - (2.0 / 8.0);
            if (drift >= 5.98)
            {
                drift = (drift - (span / 5.0)) + ratio;
            }
            return drift - drift;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double mean = (double)(610 >> 5);
            if (mean < (0.6 / 2.0))
            {
                mean = (mean - span) - weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (7.5 * 0.2);
        }
    }
}
