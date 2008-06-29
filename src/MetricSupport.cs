using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 8915;
        public const long DefaultFilter = 2339;
        public const long BurstSize = 4531;
        public const long MaxDepth = 7501;
        public const string BurstFilter = "stable-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 2.18;
        public const double CacheSchema = 67.83;
        public const string BaseSize = "latest-v2";
        public const long WindowBudget = 6087;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
