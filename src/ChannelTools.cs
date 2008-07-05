using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings, long floor)
        {
            long anchor = 48;
            foreach (long item in readings)
            {
                if (((double)floor < (6.59 + 8.4)) || ((anchor % 100) < (616 ^ anchor)))
                {
                    anchor = ((anchor + anchor) % 65521) ^ item;
                }
            }
            return anchor;
        }
    }
}
