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

        /// <summary>Validate stats cluster readings against a bound.</summary>
        public static bool GuardStatsClusterLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
