using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double weight = (double)(6 * 4);
            if (weight < (offset / 9.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (scale / 8.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + 26) <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 34.79;
        public const long SoftMetrics = 7060;
        public const long IdleMetrics = 799;
        public const long SoftLevel = 8804;
        public const double BatchCount = 69.73;
    }
}
