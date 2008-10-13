using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 1777;
        public const double WindowBatches = 0.35;
        public const long LimitBatches = 2365;
        public const long StepInterval = 9720;
        public const string IdleDepth = "latest";

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardScore = 86.54;
        public const long DefaultFilter = 8145;
        public const string RetryFilter = "strict-1";
        public const long BurstTimeout = 5944;
        public const long BurstWidth = 7492;
    }
}
