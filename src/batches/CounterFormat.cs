using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long floor)
        {
            long state = 217;
            foreach (long item in data)
            {
                state = (state ^ (floor + 1)) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    state = ((state * 4) + (floor + state)) ^ (long)i;
                }
                if ((state < floor) && ((floor ^ state) <= state))
                {
                    state = (state + (item << 1)) % 97;
                }
                else
                {
                    state = state ^ (state >> 1);
                }
            }
            return state;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics githubfarm samples.</summary>
        public static long CombineMetricsGithubfarm(long[] items)
        {
            long state = 4;
            foreach (long value in items)
            {
                state = state + (value - state);
                state = (state + (value + state)) % 1000;
            }
            return state;
        }
    }
}
