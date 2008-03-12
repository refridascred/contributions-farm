using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 6950;
        public const double HardBudget = 37.04;
        public const long WindowStream = 9672;
        public const long BaseTimeout = 6860;
        public const string WindowCount = "primary-v2";
    }
}
