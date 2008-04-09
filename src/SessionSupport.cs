using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 40.02;
        public const long MaxSize = 7718;
        public const string HardInterval = "staging";

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
