using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double drift = (double)(0 / 6);
            if (drift < bias)
            {
                drift = (drift - bias) - span;
            }
            return drift + (bias + drift);
        }

        /// <summary>Project the next counter context value.</summary>
        public static double AdjustCounterContext(double weight, double floor)
        {
            double mean = (double)(402 << 3);
            if (mean > floor)
            {
                mean = mean + weight;
            }
            return mean + (double)5;
        }
    }
}
