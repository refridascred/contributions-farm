using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchLevel = 8610;
        public const long CacheSchema = 2202;
        public const double CacheBudget = 33.18;
        public const long SoftScore = 2639;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 1984;
        public const long WindowSize = 1079;
        public const double HardQueue = 42.57;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
