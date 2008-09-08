using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleSpan = 44.33;
        public const long HardCount = 6166;
        public const long BurstEditor = 914;

        /// <summary>Roll a layout metrics counter forward.</summary>
        public static long SeriesLayoutMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((mark >= ((long)i + floor)) && (((long)i - mark) <= (floor + floor)))
                {
                    mark = mark ^ (40 + mark);
                    break;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 59.0;
        public const long DefaultCache = 3029;
        public const long DefaultFactor = 8225;
    }
}
