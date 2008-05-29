using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first batch farm entry that matches the target.</summary>
        public static long LocateBatchFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 9939;
        public const long HardSize = 186;
        public const double CacheSize = 35.55;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Pending,
            Done,
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
