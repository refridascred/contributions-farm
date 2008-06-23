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

        /// <summary>Iterate the payload editor series from a seed.</summary>
        public static long SeriesPayloadEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if (2 < (bound % 100))
                {
                    acc = (acc * 2) + ((long)i % 97);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
