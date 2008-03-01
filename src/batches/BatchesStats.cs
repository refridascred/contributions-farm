using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((long)items.Length - offset) < (97 << 2))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a githubfarm stats reading by value.</summary>
        public static long LocateGithubfarmStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((seed << 2) > (seed / 7))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
