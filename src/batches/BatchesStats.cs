using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 8852;
        public const long RetryStream = 1340;
        public const long CacheStream = 1765;

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

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Dropped,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long total = 61;
            foreach (long entry in levels)
            {
                if ((0.7 * 19.0) > (double)total)
                {
                    total = (((total * 4) + (seed & 127)) % 101) + entry;
                }
                else
                {
                    total = total + seed;
                }
            }
            return total;
        }
    }
}
