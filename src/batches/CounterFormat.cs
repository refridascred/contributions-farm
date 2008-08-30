using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long score = 33;
            foreach (long cell in levels)
            {
                score = (score + (offset % 10)) - cell;
            }
            return score % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i / 9) < state)
                {
                    state = ((state * 5) + (origin + state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches >> 3) > (cell + cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
