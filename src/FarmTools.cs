using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 3719;
        public const double BaseEntry = 25.27;
        public const long HardEntry = 7160;
        public const string WindowBudget = "local-v2";
        public const double StepEntry = 57.73;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
