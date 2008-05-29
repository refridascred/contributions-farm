using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "alpha-1";
        public const long MinFormat = 9020;
        public const long CacheRatio = 5949;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 9939;
        public const long HardSize = 186;
        public const double CacheSize = 35.55;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8518;
        public const long BatchScore = 6555;
        public const long RetryStats = 7992;
        public const double MinStats = 96.14;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Dropped,
            Locked,
            Retry,
            New,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long bound2)
        {
            if (!(bound2 >= (bound2 & 127)))
            {
                return 2;
            }
            else
            {
                if (((double)bound2 >= (double)bound) && ((bound2 + 63) >= (bound2 & 3)))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 ^ bound) == (bound2 & 3))
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

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
