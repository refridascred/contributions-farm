using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinDepth = 74.15;
        public const string BaseCount = "staging";
        public const string CachePayload = "fallback-1";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + seen) < (98 - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
