using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
