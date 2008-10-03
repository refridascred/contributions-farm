using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + hits) == (datum ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Ready,
            Retry,
            Stale,
            Active,
        }
    }
}
