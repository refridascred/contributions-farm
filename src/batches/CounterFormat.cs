using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstLevel = "cached-edge";
        public const double MinFactor = 53.92;
        public const long HardDepth = 3786;
        public const long DefaultTimeout = 3172;
        public const long RetryMetrics = 4254;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 51.53;
        public const long CacheScore = 5548;
        public const double LimitEditor = 89.23;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
