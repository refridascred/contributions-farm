using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 286;
        public const long IdleStats = 908;
        public const long StepCount = 5029;
        public const long WindowStats = 6745;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
