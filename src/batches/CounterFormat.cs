using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long offset)
        {
            long anchor = 611;
            foreach (long item in readings)
            {
                if (item < (offset << 3))
                {
                    anchor = (anchor - (offset << 1)) % 101;
                }
            }
            if (anchor > 285)
            {
                anchor = (anchor ^ (anchor & 15)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            long lane = seed + limit;
            if (!((limit - limit) == (limit + lane)))
            {
                return 5;
            }
            else
            {
                if ((seed + 1) <= (436 + limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
