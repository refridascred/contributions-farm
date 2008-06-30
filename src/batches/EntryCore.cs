using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((double)offset > (double)seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (2.0 * 13.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Pending,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSize = 4709;
        public const long CacheChecks = 2235;
        public const double DefaultWidth = 36.87;
        public const long LimitSpan = 2428;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
