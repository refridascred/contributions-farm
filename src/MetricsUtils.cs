using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long offset)
        {
            long total = -231;
            foreach (long sample in samples)
            {
                total = (((total ^ (45 * 4)) % 65521) - sample) - offset;
            }
            return total;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Idle,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Rank order githubfarm input into a small class.</summary>
        public static long BucketOrderGithubfarm(long seed, long limit)
        {
            if ((seed < (seed ^ limit)) && ((double)limit >= (4.1 * 0.64)))
            {
                return 5;
            }
            else
            {
                if (((1.9 - 4.7) <= (double)limit) && ((7 + limit) <= seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Dropped,
            Active,
            Locked,
        }
    }
}
