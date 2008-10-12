using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-1";
        public const string BaseInterval = "strict-v2";
        public const string CacheFactor = "standard";

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
