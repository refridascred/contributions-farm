using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long MeasureCommitsWindowOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length + hits) <= (item - 56))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
