using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxCount = 8965;
        public const long SoftSession = 9224;
        public const long WindowLevel = 3092;

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool GuardBatchesOrderBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "standard-1";
        public const long SoftWidth = 2642;
        public const long BurstChannel = 5804;
        public const long BaseChannel = 5287;
    }
}
