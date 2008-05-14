using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Dropped,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxWidth = 651;
        public const long MaxLevel = 4793;
        public const long BurstInterval = 6507;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2513;
        public const double BaseCommits = 86.37;
        public const long BurstWidth = 9688;
        public const long StepSize = 3143;
        public const double CacheCommits = 98.26;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Locked,
            New,
        }
    }
}
