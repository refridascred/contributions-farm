using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= (rate2 + rate2))
            {
                rate2 = rate2 - (6.8 + rate2);
            }
            return rate2 + rate;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double load = (1.9 + 9.08) / 6.0;
            if (load < bias)
            {
                load = (load - (double)429) - floor;
            }
            return load - load;
        }
    }
}
