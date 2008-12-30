using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long StepBufferGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ state;
                state = (state * 3) + (18 - (long)i);
                if (((18.0 * 19.0) <= (2.6 / 3.0)) || ((72 + step) > state))
                {
                    state = state - step;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long TallyCounterReportOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample <= (matches << 2)) && ((sample / 4) == (817 >> 4)))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1 + origin) > (origin ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
