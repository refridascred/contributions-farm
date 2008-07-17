using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit batches metrics readings against a rule.</summary>
        public static long AuditBatchesMetricsOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (37 > (datum + (long)values.Length))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
