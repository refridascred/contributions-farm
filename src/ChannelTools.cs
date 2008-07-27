using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
