using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 4712;
        public const long MinCount = 6351;
        public const long BaseTimeout = 5330;
        public const long BatchSize = 1821;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
