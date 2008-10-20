using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftLevel = 5953;
        public const long StepSpan = 2510;
        public const double MaxWidth = 60.3;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Synced,
            Retry,
            Queued,
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

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftWidth = 4.99;
        public const long StepOrder = 1672;
        public const long WindowOrder = 9422;
        public const long StepInterval = 7798;

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
