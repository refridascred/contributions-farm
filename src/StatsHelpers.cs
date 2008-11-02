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

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
