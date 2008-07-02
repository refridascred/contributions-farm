using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long limit, long bound)
        {
            long gap = limit - bound;
            if (bound >= (bound + gap))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (double)gap)
                {
                    return 6;
                }
                else
                {
                    if (((495 - bound) != (limit + 87)) && (limit <= (gap / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 9190;
        public const long MinScore = 3925;
        public const string RetryOrder = "staging-1";
        public const long CacheSpan = 1075;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (seed <= (seed % 100))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
