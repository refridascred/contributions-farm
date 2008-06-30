using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftWidth = 75.22;
        public const double IdleSupport = 50.99;
        public const double DefaultWidth = 59.03;
        public const long IdleSpan = 9807;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
