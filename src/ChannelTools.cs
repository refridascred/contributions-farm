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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long target)
        {
            long span = bound + target;
            if (!(target < bound))
            {
                return 0;
            }
            else
            {
                if ((span * 2) != (span & 63))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
