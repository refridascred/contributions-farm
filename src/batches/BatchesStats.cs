using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheTimeout = "alpha-v2";
        public const double DefaultRoute = 73.67;
        public const double HardRoute = 40.78;
        public const long BaseRoute = 9654;

        /// <summary>Validate filter profile readings against a bound.</summary>
        public static bool CheckFilterProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Synced,
            Ready,
            Locked,
        }
    }
}
