using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 560;
        public const string BaseTimeout = "open-1";
        public const long WindowFormat = 405;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2513;
        public const double BaseCommits = 86.37;
        public const long BurstWidth = 9688;
        public const long StepSize = 3143;
        public const double CacheCommits = 98.26;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
