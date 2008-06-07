using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels, long target)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (double)mark)
                {
                    mark = mark ^ (mark + mark);
                }
            }
            if (mark > 31)
            {
                mark = ((mark * 5) + target) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long limit)
        {
            if (limit >= (limit + 401))
            {
                return 8;
            }
            else
            {
                if (limit >= (target & 15))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Failed,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool VerifyEntryContextBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
