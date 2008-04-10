using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinBudget = 2895;
        public const long WindowBudget = 6563;
        public const long WindowLayout = 4716;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstDepth = 56.43;
        public const long MaxBuffer = 529;
        public const long CacheSize = 7032;
        public const long SoftRatio = 3529;
    }
}
