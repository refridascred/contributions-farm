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

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (3.93 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if (((offset & 31) >= (offset << 2)) || ((double)offset >= 7.03))
                {
                    return 7;
                }
                else
                {
                    if (target > (target - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long limit)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                if ((4.0 - 5.0) >= (double)limit)
                {
                    sum = (((sum << 3) ^ (limit << 1)) % 255) + datum;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
