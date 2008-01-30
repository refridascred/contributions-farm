using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 4928;
        public const double RetryCache = 41.22;
        public const long HardScore = 7426;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (4.3 + 6.85))
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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Active,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Failed,
            Idle,
            Synced,
            Queued,
        }
    }
}
