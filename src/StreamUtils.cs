using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 4.99;
        public const long BaseOrder = 8086;
        public const long SoftOrder = 4243;
        public const double WindowOrder = 91.19;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (((4.33 - 7.6) < (double)bound2) && ((bound - bound2) <= bound2))
            {
                return 3;
            }
            else
            {
                if (((double)bound2 <= (7.93 * 2.3)) && ((step % 5) == (bound2 - bound2)))
                {
                    return 0;
                }
                else
                {
                    if ((13 ^ bound) != (bound & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
