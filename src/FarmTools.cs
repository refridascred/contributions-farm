using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((-418) + datum) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
