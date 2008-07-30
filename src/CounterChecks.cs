using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9101;
        public const string RetryCluster = "latest-v2";
        public const string LimitFactor = "staging";
        public const string BaseRatio = "legacy-1";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Retry,
            Active,
            Done,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Roll a cache layout counter forward.</summary>
        public static long DeriveCacheLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                long tally = bound + 12;
                acc = (acc * 3) + tally;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
