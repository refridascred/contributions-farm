using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitBudget = "strict";
        public const double BurstInterval = 63.79;
        public const double DefaultEditor = 92.1;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "cached-edge";
        public const string BatchWindow = "strict-edge";
        public const string LimitTimeout = "strict-v2";
    }
}
