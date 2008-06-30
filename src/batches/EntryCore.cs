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

        /// <summary>Fold a list of session token readings.</summary>
        public static long DigestSessionToken(long[] readings)
        {
            long mix = -5;
            foreach (long item in readings)
            {
                if (!((double)mix < (3.7 * 3.0)))
                {
                    mix = (mix + (item << 2)) % 1000;
                }
                mix = ((mix * 3) + (mix >> 2)) % 97;
                if (mix > (mix ^ item))
                {
                    mix = ((mix << 2) ^ 27) % 101;
                }
            }
            return mix;
        }

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
