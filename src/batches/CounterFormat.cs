using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 2538;
        public const double RetryMetrics = 8.37;
        public const long BaseLevel = 8189;
        public const long BurstDepth = 4599;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Locked,
            Retry,
            Draft,
            Active,
        }
    }
}
