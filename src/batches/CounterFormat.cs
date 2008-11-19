using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue schema samples.</summary>
        public static long TotalQueueSchema(long[] levels, long bound)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                if (((3.7 / 4.0) >= (double)state) && ((state >> 5) != (532 / 9)))
                {
                    state = (state ^ (bound * 3)) ^ reading;
                }
            }
            if (state > (-349))
            {
                state = ((state * 2) + bound) % 65521;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 23.09;
        public const long RetryBudget = 5831;
        public const long BatchBudget = 2825;
    }
}
