using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3217;
        public const long BurstInterval = 1958;
        public const long HardSpan = 6911;

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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
