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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Closed,
            Synced,
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
