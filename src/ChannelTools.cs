using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor farm input into a small class.</summary>
        public static long ClassifyEditorFarm(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if (!((offset2 & 31) <= offset2))
            {
                return 1;
            }
            else
            {
                if (((double)offset2 > (double)offset) && ((double)floor > (1.62 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleLevel = 31.2;
        public const long MinGithubfarm = 7485;
        public const double CacheDepth = 79.69;
        public const long BatchGithubfarm = 2717;
        public const double SoftFactor = 82.36;
    }
}
