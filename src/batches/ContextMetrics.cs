using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 4589;
        public const double BaseLayout = 65.27;
        public const string MaxLayout = "fallback-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2442;
        public const long IdleEntry = 3173;
        public const string BurstEntry = "standard-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "standard-v2";
        public const long StepTools = 7534;
        public const long BaseSpan = 6349;
        public const long CacheTools = 8457;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (8.2 + 2.88))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry buffer measurements.</summary>
        public static double BlendEntryBuffer(double scale, double bias)
        {
            double ratio = (double)6 - bias;
            return (ratio - (bias * 7.8)) + scale;
        }
    }
}
