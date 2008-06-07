using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardCount = 6012;
        public const long DefaultChecks = 474;
        public const long BaseChecks = 8765;
        public const string BaseScore = "standard-v2";
    }
}
