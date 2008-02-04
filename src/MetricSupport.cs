using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6770;
        public const string SoftSpan = "stable";
        public const double MinGraph = 4.43;
        public const long CacheLevel = 7732;
        public const long BatchSpan = 5972;
    }
}
