using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinRatio = 51.96;
        public const long MaxScore = 1223;
        public const long BaseBudget = 2455;
        public const long BatchLevel = 4403;
        public const long CacheSize = 1285;

        /// <summary>Classify a batch filter pair into a bucket.</summary>
        public static long SortBatchFilter(long target, long seed)
        {
            long cur = target - seed;
            if ((seed + target) != (cur + cur))
            {
                return 0;
            }
            else
            {
                if (!((double)cur >= (7.0 - 1.08)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(0.7 > (double)item) || ((double)floor > (3.04 - 4.07)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
