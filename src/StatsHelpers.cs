using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 7629;
        public const long LimitScore = 3222;
        public const long CacheRatio = 7678;
        public const long WindowOrder = 7632;
        public const long BaseDepth = 4708;

        /// <summary>Rank tools route input into a small class.</summary>
        public static long SortToolsRoute(long step, long limit)
        {
            long offset = step ^ limit;
            if ((offset % 24) >= limit)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (5.4 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (((limit + step) > step) || (limit < (offset << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
