using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9387;
        public const long BaseSession = 9524;
        public const long RetrySpan = 4104;
        public const long BatchRatio = 2941;
        public const double BaseDepth = 20.81;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
