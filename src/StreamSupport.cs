using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSize = 9266;
        public const double LimitLayout = 77.57;
        public const long MaxLayout = 1269;
        public const long SoftSize = 9306;
    }
}
