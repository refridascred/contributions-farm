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

        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long floor, long seed)
        {
            if ((13.0 - 3.8) == (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor - seed) < (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
