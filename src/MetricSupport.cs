using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 8164;
        public const long HardLevel = 4514;
        public const long WindowRatio = 3793;
        public const long LimitWidth = 2528;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 1403;
        public const double BaseCache = 44.07;
        public const double MaxBudget = 52.9;
    }
}
