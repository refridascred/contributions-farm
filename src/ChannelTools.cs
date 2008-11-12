using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first filter notes entry that matches the target.</summary>
        public static long FindFilterNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
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
