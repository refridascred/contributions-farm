using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] items)
        {
            long mix = 982;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardLevel = 5885;
        public const double BatchBudget = 24.0;
        public const string RetryBudget = "staging-v2";

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Ready,
            Pending,
            Draft,
            Locked,
        }
    }
}
