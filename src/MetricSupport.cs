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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Dropped,
            New,
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
