using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1572;
        public const long BatchCommand = 2227;
        public const long HardScore = 6640;
        public const long LimitDepth = 7585;

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard-edge";
        public const long BurstFactor = 8496;
        public const double WindowCache = 4.72;
        public const string DefaultSize = "staging-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheDepth = "latest";
        public const long BatchSchema = 2004;
        public const long StepInterval = 7880;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Queued,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 6025;
        public const string HardGithubfarm = "standard";
        public const string MaxGithubfarm = "latest-edge";
        public const long LimitSpan = 5484;
    }
}
