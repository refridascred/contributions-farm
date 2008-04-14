using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)cell < 0.44) && (((cell ^ count) < (count + count)) || ((cell >> 2) == (count ^ cell))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
