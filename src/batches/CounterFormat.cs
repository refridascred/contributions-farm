using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 2917;
        public const string MaxReport = "cached-1";
        public const string RetryReport = "cached-edge";
        public const long MinFactor = 6343;
        public const long DefaultReport = 681;

        /// <summary>Roll a session account counter forward.</summary>
        public static long IterateSessionAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i < state)
                {
                    state = (state ^ seed) % 4096;
                }
                else
                {
                    state = (state - (state & 15)) % 4096;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((limit - limit) != (tally + tally))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
