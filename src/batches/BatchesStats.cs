using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value >= (hits ^ hits))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + 481) < (21 * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
