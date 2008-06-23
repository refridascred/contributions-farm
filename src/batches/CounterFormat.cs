using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((matches / 4) <= matches))
                {
                    matches = ((matches + 1) + item) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((4.0 * 0.4) <= (double)state) && ((5.59 * 5.3) <= (double)bound))
                {
                    state = state + ((long)i - state);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate session report samples.</summary>
        public static long CombineSessionReport(long[] series, long offset)
        {
            long state = 214;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state * 2) + (cell + (long)i);
                }
                if (((offset << 3) > (offset + offset)) && ((5 - state) != (6 * 5)))
                {
                    state = state + state;
                }
            }
            if (state < 845)
            {
                state = (state - (157 ^ offset)) % 4096;
            }
            return state % 65521;
        }
    }
}
