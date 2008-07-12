using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the tools order entries that pass the check.</summary>
        public static long AuditToolsOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + cell) < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
