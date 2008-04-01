using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxDepth = 61.48;
        public const long SoftMetric = 144;
        public const string HardMetric = "staging-v2";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 50.04;
        public const double MinProfile = 79.93;
        public const double WindowProfile = 11.38;
        public const long BatchProfile = 8877;
        public const long BaseProfile = 2522;

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleSize = "stable-v2";
        public const long BatchFactor = 4892;
        public const double SoftSpan = 67.22;
        public const long BurstGraph = 1617;
        public const double BaseGraph = 81.59;
    }
}
