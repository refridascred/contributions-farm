using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5795;
        public const long DefaultScore = 1691;
        public const double CacheDepth = 26.97;
        public const long RetryTimeout = 4947;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long sum = -6;
            foreach (long entry in levels)
            {
                if ((sum + sum) >= entry)
                {
                    sum = (sum ^ 9) % 97;
                }
            }
            if (sum < 672)
            {
                sum = (sum << 3) ^ (161 * 4);
            }
            return sum;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            if ((offset <= (offset2 - offset)) && ((double)offset2 >= (18.0 * 1.0)))
            {
                return 7;
            }
            else
            {
                if (offset2 > (offset2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(18.0 < (double)count))
                {
                    count = ((count + 1) ^ reading) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
