using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Adjust a route support reading.</summary>
        public static double ProjectRouteSupport(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 13.0) - (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 5.42;
        public const double CacheDepth = 48.93;
        public const long DefaultPayload = 4790;
        public const double StepPayload = 60.89;
        public const string BurstFactor = "local";

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double bias = floor - rate;
            return bias - 13.0;
        }
    }
}
