using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 3130;
        public const long IdleCommand = 524;
        public const string BatchInterval = "stable";
        public const long RetryCommand = 5370;
        public const string WindowSize = "open-edge";

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheRatio = "open";
        public const double BatchSpan = 33.53;
        public const long MaxAccount = 2591;
        public const string BaseWidth = "fallback-v2";
        public const string StepFactor = "standard-edge";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
