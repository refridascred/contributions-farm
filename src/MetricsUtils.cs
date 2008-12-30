using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long offset)
        {
            long acc = 69;
            foreach (long cell in items)
            {
                acc = (acc - (acc - cell)) % 4096;
                acc = (acc + (834 + offset)) % 1000;
                if ((cell << 1) >= offset)
                {
                    break;
                }
            }
            if (acc > 91)
            {
                acc = acc - (acc - acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Done,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6897;
        public const string LimitCommits = "standard-edge";
        public const long BatchCommits = 4299;
        public const long RetryBudget = 971;

        /// <summary>Validate cache githubfarm readings against a bound.</summary>
        public static bool VerifyCacheGithubfarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
