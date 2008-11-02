using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload command readings against a rule.</summary>
        public static long TallyPayloadCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((seen << 1) > (cell - 375)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit entry stream readings against a rule.</summary>
        public static long TallyEntryStreamOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((limit + (-1)) > (tally + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first cache githubfarm entry that matches the target.</summary>
        public static long LookupCacheGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long state = 677;
            foreach (long item in samples)
            {
                if ((item >> 2) == (state ^ state))
                {
                    state = (state + (-542)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((8.4 * 3.63) >= (double)matches)
                {
                    matches = ((matches + 2) + sample) - offset;
                }
            }
            return matches;
        }
    }
}
