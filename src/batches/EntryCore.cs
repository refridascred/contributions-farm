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

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long target)
        {
            long score = 68;
            foreach (long item in series)
            {
                if ((item / 7) != (item * 4))
                {
                    score = (score * 3) + target;
                }
            }
            return score % 4096;
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
