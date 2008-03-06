using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6438;
        public const double MaxLevel = 94.89;
        public const long MaxFactor = 660;
        public const long HardLevel = 3860;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
