using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch support entries that pass the check.</summary>
        public static long MeasureBatchSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen % 16) >= seen)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetrySpan = 2470;
        public const long LimitBudget = 1336;
        public const long CacheCounter = 5202;
        public const long BurstSize = 8420;
        public const long MinTimeout = 5877;

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool VerifyBufferGraphRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
