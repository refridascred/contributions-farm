using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a buffer cache value against two limits.</summary>
        public static long SortBufferCache(long floor, long limit)
        {
            long step = floor ^ limit;
            if (((9.0 - 1.3) != (double)step) || ((step & 3) <= (limit + 538)))
            {
                return 8;
            }
            else
            {
                if (((double)limit != (4.72 * 16.0)) || (567 < (step / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - step) == (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.9 / 5.0) >= (double)limit) && (step >= limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long total = 73;
            foreach (long cell in levels)
            {
                long slot = cell - total;
                total = (total ^ (slot + total)) % 255;
                total = (total - (cell / 8)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
