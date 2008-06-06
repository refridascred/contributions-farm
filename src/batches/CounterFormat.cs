using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Pending,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultScore = 28.38;
        public const string BurstSpan = "standard";
        public const double MaxPayload = 21.85;
        public const long BatchScore = 9401;
        public const long WindowPayload = 3101;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
