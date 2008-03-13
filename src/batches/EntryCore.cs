using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of batch context readings.</summary>
        public static long PairBatchContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 74.71;
        public const string HardSupport = "stable-v2";
        public const long BatchSupport = 9398;
        public const long RetrySupport = 4614;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Synced,
            New,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 21.89;
        public const string HardFactor = "fallback";
        public const long DefaultFormat = 2429;
        public const string BatchFormat = "primary";
        public const long WindowWidth = 7333;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Queued,
            Ready,
            Draft,
        }
    }
}
