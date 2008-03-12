using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route cache values into a single score.</summary>
        public static long FoldRouteCache(long[] items, long floor)
        {
            long mix = 811;
            foreach (long value in items)
            {
                if ((double)(long)items.Length <= (2.2 / 9.0))
                {
                    mix = (mix - floor) % 101;
                    mix = (mix + (value + value)) % 1000;
                }
                else
                {
                    mix = (mix ^ (674 + (-231))) % 97;
                }
                mix = mix - ((long)items.Length - 67);
            }
            return mix;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long limit)
        {
            long edge = seed - limit;
            if ((limit * 4) != (limit + limit))
            {
                return 3;
            }
            else
            {
                if (((limit - limit) <= limit) && ((limit + edge) > limit))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
