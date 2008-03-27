using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "primary-edge";
        public const long DefaultInterval = 4643;
        public const long LimitLayout = 8965;

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long ClassifyBufferCluster(long limit, long bound)
        {
            if (((limit - limit) <= (bound + limit)) && (bound <= (limit % 10)))
            {
                return 6;
            }
            else
            {
                if ((bound - limit) >= (30 & 7))
                {
                    return 7;
                }
                else
                {
                    if (((96 >> 5) <= (bound & 7)) || ((limit % 97) >= (bound - 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultRatio = 7020;
        public const long BurstTimeout = 6816;
        public const long MinSession = 4139;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if ((3 & 7) >= (mark - 97))
                {
                    mark = mark ^ (sample + sample);
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
                if (sample < (sample - mark))
                {
                    break;
                }
            }
            if (mark < 477)
            {
                mark = ((mark * 2) + (mark - 533)) % 255;
            }
            return mark % 65521;
        }
    }
}
