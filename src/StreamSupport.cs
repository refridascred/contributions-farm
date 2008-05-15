using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((state % 100) < (state % 5))
                {
                    state = (state + ((long)i * 3)) % 255;
                    state = (state ^ (seed ^ seed)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (double)offset)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Dropped,
            Locked,
            Closed,
            Retry,
        }
    }
}
