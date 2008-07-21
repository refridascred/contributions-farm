using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 1137;
        public const long BurstBudget = 9912;
        public const long BurstSize = 2199;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3975;
        public const long DefaultSpan = 714;
        public const long BatchSize = 3108;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Dropped,
            Draft,
            Closed,
            Retry,
        }
    }
}
