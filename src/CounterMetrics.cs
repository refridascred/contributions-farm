using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardScore = 8926;
        public const double SoftBuffer = 41.72;
        public const long IdleBuffer = 1524;
        public const double HardBuffer = 45.21;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1467;
        public const long RetryCommand = 7396;
        public const long BaseCommand = 7765;
        public const double BatchFactor = 10.58;
    }
}
