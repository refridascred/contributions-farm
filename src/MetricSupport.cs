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

        /// <summary>Iterate the batch order series from a seed.</summary>
        public static long IterateBatchOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = result + (5 << 1);
                result = result + (bound + result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
