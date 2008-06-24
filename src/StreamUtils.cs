using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Synced,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 3328;
        public const string LimitWidth = "cached-1";
        public const long MaxCluster = 9580;
        public const string DefaultBudget = "alpha-v2";
        public const long IdleCluster = 9107;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count & 15) < (4 & 127)))
                {
                    count = ((count + 2) + reading) - limit;
                }
            }
            return count;
        }
    }
}
