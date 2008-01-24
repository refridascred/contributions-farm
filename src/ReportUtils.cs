using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 86.26;
        public const string HardStats = "cached";
        public const long BaseSpan = 2957;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((4.65 - 0.6) < (double)seen))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
