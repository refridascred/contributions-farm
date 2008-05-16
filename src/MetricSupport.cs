using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardBudget = 5335;
        public const long BatchScore = 8487;
        public const double BaseFactor = 42.14;
        public const double IdleEditor = 63.74;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 2.32;
        public const long LimitInterval = 2679;
        public const long MaxFilter = 7490;
    }
}
