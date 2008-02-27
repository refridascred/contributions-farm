using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the buffer channel series from a seed.</summary>
        public static long RollBufferChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step & 7) < step)
                {
                    result = ((result << 3) ^ (result << 1)) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long mix = -8;
            foreach (long sample in levels)
            {
                mix = (((mix + (mix + mix)) % 4096) ^ sample) + offset;
            }
            return mix;
        }

        /// <summary>Grade a layout cluster value against two limits.</summary>
        public static long ClassifyLayoutCluster(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (bound2 <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound + cur) < (6 ^ bound2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
