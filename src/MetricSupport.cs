using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleFactor = 56.21;
        public const double HardTimeout = 16.14;
        public const long MaxCounter = 6581;
        public const string WindowCounter = "alpha-edge";
        public const long BaseRatio = 8397;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
