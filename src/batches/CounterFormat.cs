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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (limit / 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
