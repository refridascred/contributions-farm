using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!!((4 - entry) <= (90 % 97)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
