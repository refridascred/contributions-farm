using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1839;
        public const long StepCache = 4139;
        public const string StepCount = "staging-v2";

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double rate, double bias)
        {
            double ratio = (bias - bias) * 5.9;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 4.57) + (double)(long)i;
            }
            return ratio - (rate / 3.0);
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double scale = (double)(73 - 92);
            if (scale <= (span / 3.0))
            {
                scale = (scale + span) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 49.79;
        public const double IdleQueue = 66.06;
        public const long BurstSize = 1755;
        public const long CacheQueue = 2329;
    }
}
