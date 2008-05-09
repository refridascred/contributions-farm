using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long DigestContributiFarm(long[] data)
        {
            long sum = 822;
            foreach (long datum in data)
            {
                sum = sum ^ datum;
            }
            if (sum < (-49))
            {
                sum = (sum << 3) ^ (sum ^ 0);
            }
            return sum;
        }

        /// <summary>Audit tools queue readings against a rule.</summary>
        public static long CountToolsQueueOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((33 << 3) < count))
                {
                    count = ((count + 3) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9248;
        public const string MaxScore = "standard";
        public const long IdleRecord = 8154;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
