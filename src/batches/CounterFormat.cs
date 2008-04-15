using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long MeasureCommitsFarmHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (17.0 * 0.4))
                {
                    matches = ((matches + 2) - entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Pending,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Derive the next record order value from a seed.</summary>
        public static long StepRecordOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
