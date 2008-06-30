using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 2049;
        public const double IdleCluster = 18.3;
        public const string RetrySize = "primary-v2";
        public const string WindowBudget = "primary-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSize = 9507;
        public const long BatchInterval = 7830;
        public const long IdleQueue = 4557;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
