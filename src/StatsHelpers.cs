using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 44.57;
        public const double MaxSession = 66.86;
        public const long MinSession = 4390;
        public const long LimitWidth = 6341;
        public const long BatchLevel = 3410;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            New,
            Retry,
            Active,
        }

        /// <summary>Audit window schema readings against a rule.</summary>
        public static long AuditWindowSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((value + value) != (value & 63)) || (1 <= value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
