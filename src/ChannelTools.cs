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

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((total + total) <= limit))
                {
                    total = total + (795 >> 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
