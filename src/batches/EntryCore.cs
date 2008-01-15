using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3399;
        public const double CacheScore = 8.48;
        public const string BaseChannel = "fallback";
        public const double DefaultScore = 67.56;
        public const string BaseWidth = "latest";

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double bias = 7.9;
            if (bias > offset)
            {
                bias = (bias + offset) - rate;
            }
            return bias + (9.0 - bias);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally >> 4) != (datum >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
