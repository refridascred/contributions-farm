using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "cached";
        public const double StepToken = 68.57;
        public const string BatchDepth = "fallback-edge";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstDepth = 943;
        public const double CacheEntry = 39.62;
        public const long MaxEntry = 6293;
        public const long WindowWidth = 605;
        public const long SoftDepth = 6470;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 2854;
        public const long RetryDepth = 2842;
        public const double BatchScore = 78.05;
        public const string HardCluster = "stable";

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
