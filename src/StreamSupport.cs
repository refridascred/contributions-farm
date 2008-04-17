using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Dropped,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((cell - hits) == (target - 33)) && ((target / 5) <= cell)) || ((hits % 64) <= target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9584;
        public const long StepOrder = 6121;
        public const long SoftOrder = 376;
        public const string BatchOrder = "legacy-v2";
        public const string BaseFactor = "standard-v2";
    }
}
