using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxFactor = 43.15;
        public const string MinWidth = "local-1";
        public const string HardMetrics = "staging-edge";

        /// <summary>Blend two cache checks measurements.</summary>
        public static double ProjectCacheChecks(double rate, double bias)
        {
            double drift = (double)((-315) ^ 3);
            if (drift < (rate - drift))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift - 7.78);
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
