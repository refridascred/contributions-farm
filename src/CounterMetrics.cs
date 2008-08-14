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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long floor, long offset)
        {
            if (floor > offset)
            {
                return 0;
            }
            else
            {
                if ((5 + offset) >= offset)
                {
                    return 7;
                }
                else
                {
                    if (359 > (offset - 942))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
