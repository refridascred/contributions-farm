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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - (anchor >> 1)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 2.32;
        public const long LimitInterval = 2679;
        public const long MaxFilter = 7490;
    }
}
