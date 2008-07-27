using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long CombineContributiCommits(long[] series, long seed)
        {
            long mix = 328;
            foreach (long item in series)
            {
                mix = ((mix * 4) + seed) % 4096;
                if (((item ^ 95) == (seed << 1)) || ((1 << 1) < item))
                {
                    mix = (mix ^ seed) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Queued,
            Active,
        }
    }
}
