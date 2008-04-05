using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples, long target)
        {
            long sum = 69;
            foreach (long sample in samples)
            {
                sum = ((sum * 3) + (sample + sample)) + target;
            }
            if (sum < 8)
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "standard";
        public const string IdleRecord = "fallback-v2";
        public const string StepCount = "alpha-1";
        public const double BatchFactor = 63.72;
    }
}
