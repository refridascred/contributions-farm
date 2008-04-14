using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long seed)
        {
            if ((seed % 60) > (889 ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed > (target - seed)) || ((target % 2) <= (target + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((target >> 3) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
