using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two token support measurements.</summary>
        public static double ProjectTokenSupport(double ratio, double span)
        {
            double drift = span;
            if (drift < (6.69 / 4.0))
            {
                drift = drift - (ratio / 6.0);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - span;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + bias;
            }
            return drift - drift;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheSize = 57.16;
        public const long BurstCluster = 529;
        public const string LimitCluster = "staging-edge";
        public const long HardCluster = 6489;
        public const double CacheCluster = 65.54;
    }
}
