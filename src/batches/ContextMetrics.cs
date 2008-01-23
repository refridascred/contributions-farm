using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftLevel = 9129;
        public const string BaseTimeout = "standard";
        public const long RetrySize = 1073;
        public const double RetryPayload = 37.72;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            New,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long sum = -211;
            foreach (long value in data)
            {
                if (value > (sum + value))
                {
                    sum = ((sum << 2) ^ sum) + target;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long CountGithubfarmBatchOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (18 >= hits)
                {
                    hits = ((hits + 2) - item) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
