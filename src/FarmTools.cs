using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + 21) > (state % 12))
                {
                    state = state - 436;
                }
                else
                {
                    state = (state + (state + 3)) % 1000;
                }
                if ((double)state < (6.0 / 3.0))
                {
                    state = (state ^ (state << 3)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ value;
                }
                if ((1.17 - 8.37) != (double)value)
                {
                    state = ((state * 5) + (state + value)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((double)21 == (double)tally) && (6.42 >= (double)tally)) || (((tally - seed) > sample) && (((-9) ^ tally) == (6 + 46))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up already order samples.</summary>
        public static long OverlapAlreadyOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
