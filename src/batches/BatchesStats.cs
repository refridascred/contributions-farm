using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine route order values into a single score.</summary>
        public static long DigestRouteOrder(long[] values, long bound)
        {
            long result = 268;
            foreach (long item in values)
            {
                if (!((bound - 3) == (result % 97)))
                {
                    result = ((result ^ (29 - result)) % 1000) ^ item;
                }
            }
            return result % 97;
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
