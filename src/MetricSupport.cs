using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Ready,
            Active,
            Stale,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + 8) != (hits << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Paused,
            Stale,
        }
    }
}
