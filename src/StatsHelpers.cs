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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((98 + bound) == (bound << 2))
                {
                    sum = sum ^ ((long)i ^ (long)i);
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Locked,
            Stale,
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
