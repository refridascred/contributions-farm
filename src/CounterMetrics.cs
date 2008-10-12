using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 73.8;
        public const long MaxFactor = 7750;
        public const long CacheContributi = 3282;
        public const long SoftLevel = 9443;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long offset)
        {
            if ((double)offset <= (6.7 / 9.0))
            {
                return 5;
            }
            else
            {
                if (!((offset >> 3) > floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((963 - value) >= (value / 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
