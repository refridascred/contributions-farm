using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long target)
        {
            long span = bound + target;
            if ((bound > span) && ((18.0 - 8.22) > (double)target))
            {
                return 5;
            }
            else
            {
                if ((3.1 * 9.74) <= (19.0 + 16.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i - (long)i) == ((long)i - offset)))
                {
                    state = state + (state >> 1);
                    state = ((state << 3) ^ (offset >> 5)) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
