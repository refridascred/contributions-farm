using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long offset)
        {
            long span = seed - offset;
            if ((double)offset > (1.7 + 0.42))
            {
                return 2;
            }
            else
            {
                if (((double)seed == (4.42 + 17.0)) || ((double)span == (8.0 + 4.6)))
                {
                    return 3;
                }
                else
                {
                    if (((offset << 3) >= offset) && ((span / 6) == (83 % 60)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 2) ^ (result & 63)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (!((item * 3) >= (acc / 4)))
                {
                    acc = (acc - (item - (-747))) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
