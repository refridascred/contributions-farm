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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
