using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4830;
        public const long SoftChecks = 5921;
        public const string BurstChecks = "latest-1";
        public const double RetryChecks = 72.39;
        public const long DefaultSpan = 8716;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Pending,
            Ready,
            Idle,
            Closed,
        }
    }
}
