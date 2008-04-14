using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (seed < (seed + 57))
            {
                return 6;
            }
            else
            {
                if ((261 ^ bound) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long sum = 92;
            foreach (long datum in readings)
            {
                sum = (sum * 2) + datum;
            }
            if (sum > 1)
            {
                sum = sum - (sum / 3);
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryScore = "local-v2";
        public const long BatchCount = 8241;
        public const long LimitTimeout = 7743;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
