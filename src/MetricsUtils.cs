using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mark = 50;
            foreach (long value in items)
            {
                if ((double)value >= 12.0)
                {
                    mark = mark ^ (value % 100);
                }
                if (((double)value < 4.0) || ((value >> 3) <= (value & 3)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (9.0 <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 444;
        public const long MaxAccount = 4263;
        public const long MaxLevel = 726;
        public const double MaxBudget = 26.79;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((1.37 + 0.69) == (double)datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
