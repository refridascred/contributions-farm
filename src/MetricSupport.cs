using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next counter tools value.</summary>
        public static double BlendCounterTools(double rate, double bias)
        {
            double bias2 = 1.16 + (rate * 16.0);
            return (bias2 - (bias2 - bias2)) + bias;
        }
    }
}
