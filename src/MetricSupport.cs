using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseCount = "stable-v2";
        public const long RetryFactor = 6888;
        public const string HardFormat = "cached-edge";

        /// <summary>Blend two stats editor measurements.</summary>
        public static double ProjectStatsEditor(double ratio, double bias)
        {
            double drift = bias - bias;
            return (drift + drift) + ratio;
        }

        /// <summary>Check that every command session entry stays within the limit.</summary>
        public static bool VerifyCommandSessionBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
