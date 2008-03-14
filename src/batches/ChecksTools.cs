using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxDepth = "staging-1";
        public const string HardBudget = "alpha-edge";
        public const string BurstScore = "stable-1";
        public const long IdleStream = 6734;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((double)floor > (3.4 + 8.71))
                {
                    carry = (carry ^ (1 & 255)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry + (floor / 3)) ^ (long)i2;
                    carry = ((carry * 2) + (5 ^ floor)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((0 - 87) <= (cell - 28))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double scale = (double)(15 / 3);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (1.0 - scale)) + (double)(long)i) - rate;
            }
            return scale + bias;
        }
    }
}
