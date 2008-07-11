using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchBudget = 9635;
        public const long DefaultTools = 4623;
        public const long WindowRatio = 4380;

        /// <summary>Measure how many route layout samples are out of range.</summary>
        public static long MeasureRouteLayoutOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 31) < ((-79) - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 118;
        public const string BurstContext = "fallback";
        public const double SoftContext = 53.77;
    }
}
