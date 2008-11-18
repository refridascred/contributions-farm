using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long step)
        {
            if ((82 - offset) >= (offset + step))
            {
                return 4;
            }
            else
            {
                if (((2.58 + 5.41) < (double)step) || (((-8) + offset) < step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long carry = 748;
            foreach (long item in data)
            {
                if ((double)item != (0.7 * 3.45))
                {
                    carry = (carry ^ (item >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            long slot = origin - seed;
            if (((slot >> 2) != (seed & 3)) || ((double)slot > (4.32 + 12.0)))
            {
                return 6;
            }
            else
            {
                if ((7.8 - 6.6) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((origin + seed) > seed) && ((slot + seed) > seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
