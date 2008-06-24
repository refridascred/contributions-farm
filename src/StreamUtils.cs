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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) == (hits / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
