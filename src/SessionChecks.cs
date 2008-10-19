using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 2523;
        public const string BatchCount = "strict-v2";
        public const long HardScore = 1371;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
