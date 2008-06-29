using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowLevel = "alpha";
        public const long LimitBatch = 4265;
        public const double BaseBudget = 45.46;
        public const long SoftBatch = 8116;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9.76 - 8.94) < (double)(long)series.Length)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((mix - 2) == (seed + 72))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
