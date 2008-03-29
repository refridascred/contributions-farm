using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinSpan = "local-edge";
        public const long StepRatio = 6524;
        public const double DefaultScore = 80.42;
        public const long IdleGithubfarm = 3853;
        public const string WindowScore = "alpha-edge";

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 75.12;
        public const double BurstFilter = 27.64;
        public const string DefaultFilter = "alpha-1";
    }
}
