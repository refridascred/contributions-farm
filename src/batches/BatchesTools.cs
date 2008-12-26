using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 5736;
        public const long MinCommits = 8435;
        public const double RetryCommits = 63.33;
        public const double MinFactor = 2.41;
        public const double BurstCommits = 94.5;

        /// <summary>Adjust a stats account reading.</summary>
        public static double ProjectStatsAccount(double weight, double bias)
        {
            double mean = 3.3;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - mean) - (double)(long)i) - weight;
            }
            return mean - (bias * 3.0);
        }

        /// <summary>Check that every support metric entry stays within the limit.</summary>
        public static bool GuardSupportMetricRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
