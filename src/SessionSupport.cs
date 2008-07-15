using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((-59) * 3) != (hits % 8))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxCount = 8.7;
        public const string SoftDepth = "latest-edge";
        public const string SoftLayout = "local-1";
        public const long RetryLayout = 3883;
        public const long LimitDepth = 6440;
    }
}
