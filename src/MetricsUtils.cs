using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry + seen) >= (549 - entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((8 + hits) > (reading ^ 717)) || ((reading / 7) == (reading << 2)))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Done,
            Queued,
            Idle,
            Closed,
        }
    }
}
