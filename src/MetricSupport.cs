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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long anchor = -4;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (anchor << 3)) - cell;
            }
            if (anchor > 741)
            {
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor % 65521;
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
