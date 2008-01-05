using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftTimeout = "legacy-1";
        public const long LimitContext = 2221;
        public const long DefaultContext = 4193;
        public const long RetryContext = 2346;
        public const long BaseBudget = 249;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 7134;
        public const double IdleScore = 71.64;
        public const long WindowFormat = 1908;
        public const string BatchScore = "strict-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 63.11;
        public const double CacheGithubfarm = 2.33;
        public const long MinGithubfarm = 4743;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
