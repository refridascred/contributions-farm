using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const long MaxBudget = 4512;
        public const long SoftScore = 6551;
        public const long RetryRatio = 9334;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
