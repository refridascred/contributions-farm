using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first account payload entry that matches the target.</summary>
        public static long SeekAccountPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long step)
        {
            if (((bound * 3) < (bound - 15)) || ((6.13 + 7.0) >= (double)step))
            {
                return 2;
            }
            else
            {
                if ((bound - 299) >= (bound / 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < (2.57 * 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6705;
        public const double LimitDepth = 92.18;
        public const long HardLevel = 9326;
    }
}
