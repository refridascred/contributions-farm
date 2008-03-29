using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const string LimitChannel = "primary-1";
        public const long IdleChannel = 272;
        public const long WindowSize = 9010;
        public const long BurstBudget = 1934;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
