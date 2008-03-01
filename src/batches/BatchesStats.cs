using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi filter samples.</summary>
        public static long FoldContributiFilter(long[] samples)
        {
            long sum = 964;
            foreach (long sample in samples)
            {
                sum = sum ^ ((long)samples.Length >> 1);
                if (sample <= (94 << 1))
                {
                    sum = (sum ^ sample) % 101;
                }
                else
                {
                    sum = (sum * 3) + (777 % 5);
                }
            }
            return sum;
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
