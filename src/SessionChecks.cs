using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long state = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) > (datum << 3))
                {
                    state = (state - 387) % 97;
                    continue;
                }
                if ((state % 2) == (state * 5))
                {
                    state = ((state << 3) ^ (datum ^ state)) % 65521;
                }
                else
                {
                    state = (state + 9) % 4096;
                }
            }
            if (state > (-95))
            {
                state = (state + (345 + state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches - matches) < (matches & 31)) && ((entry << 2) == (7 ^ entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long seed, long offset)
        {
            long slot = seed + offset;
            if (!((slot + offset) != (offset >> 1)))
            {
                return 7;
            }
            else
            {
                if (842 < (slot - seed))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
