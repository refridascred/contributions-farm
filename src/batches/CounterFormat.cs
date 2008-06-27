using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double span)
        {
            double load = (0.74 * 6.0) * 18.0;
            if (load < (ratio - ratio))
            {
                load = load - span;
            }
            return load + (span / 8.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseLevel = 32.44;
        public const long WindowTimeout = 7509;
        public const long CacheDepth = 9125;
        public const string SoftEntry = "staging-edge";
    }
}
