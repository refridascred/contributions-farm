using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "fallback-1";
        public const string DefaultCommits = "alpha-v2";
        public const long DefaultFactor = 782;
        public const long CacheCommits = 1458;
        public const long BaseBudget = 9210;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
