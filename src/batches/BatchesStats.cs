using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry >= (258 * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm counter samples are out of range.</summary>
        public static long CountFarmCounterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (origin <= (cell / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long CountGithubfarmCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (double)offset)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Dropped,
            Ready,
            Paused,
            Retry,
        }
    }
}
