using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item >> 1) >= 930)
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8680;
        public const string DefaultProfile = "local";
        public const long DefaultLevel = 9500;
        public const long HardProfile = 7556;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
