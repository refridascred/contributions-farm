using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 66.69;
        public const long LimitDepth = 7591;
        public const string CacheLayout = "local-1";
        public const long BurstTimeout = 1387;
        public const long RetryLayout = 4038;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinLevel = 6884;
        public const long RetryLevel = 5345;
        public const long WindowBudget = 5008;
        public const long BaseInterval = 7096;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double drift = gain;
            if (drift <= (drift + drift))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - offset;
        }
    }
}
