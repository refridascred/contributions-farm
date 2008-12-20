using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftLevel = 4.67;
        public const long CacheWidth = 7434;
        public const string MaxCount = "staging-1";

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstDepth = "cached-v2";
        public const long StepAlready = 5811;
        public const long DefaultSpan = 1539;
        public const double BaseAlready = 3.44;
    }
}
