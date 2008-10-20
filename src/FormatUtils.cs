using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 9784;
        public const long DefaultChannel = 2579;
        public const long BurstChannel = 8601;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long offset)
        {
            long sum = 559;
            foreach (long value in samples)
            {
                if (offset <= (value + value))
                {
                    sum = ((sum << 3) ^ (sum % 10)) % 101;
                }
            }
            if (sum < 97)
            {
                sum = sum - (offset ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long score = 6;
            foreach (long value in series)
            {
                if (score < 9)
                {
                    score = (((score << 3) ^ (366 & 255)) % 4096) - origin;
                }
                else
                {
                    score = ((score << 2) ^ (value + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Idle,
            Draft,
            Dropped,
        }
    }
}
