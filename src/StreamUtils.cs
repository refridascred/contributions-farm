using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Region { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9104;
        public const string BatchReport = "cached-edge";
        public const long BurstReport = 5484;
        public const string StepReport = "cached-v2";
        public const long MaxReport = 7148;

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryBudget = "local-v2";
        public const long MinCommits = 8872;
        public const string LimitCommits = "local-v2";
    }
}
