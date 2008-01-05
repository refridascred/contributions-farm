using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }

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
