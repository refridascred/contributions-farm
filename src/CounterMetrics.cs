using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Idle,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (9.7 + 5.56))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
