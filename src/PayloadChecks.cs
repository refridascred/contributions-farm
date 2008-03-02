using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9701;
        public const long BatchLevel = 9427;
        public const long RetryChecks = 4931;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long TallyRecordStatsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (7 > (matches - cell))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long step = origin - target;
            if (((step / 9) != (35 % 64)) && (origin <= (target - 8)))
            {
                return 0;
            }
            else
            {
                if (((origin ^ target) == (5 + target)) && ((double)step <= 7.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Synced,
            Pending,
        }
    }
}
