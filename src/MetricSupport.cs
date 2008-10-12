using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a filter account reading by value.</summary>
        public static long LocateFilterAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ (result + result);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result << 2) ^ (target - target)) % 1000) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 1491;
        public const long BaseCounter = 8249;
        public const string MaxCounter = "local";
        public const long RetryFactor = 7328;
        public const long LimitCounter = 2522;
    }
}
