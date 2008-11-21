using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Done,
            Failed,
            New,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Active,
            Queued,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double load = 3.4;
            return (load + span) + ratio;
        }
    }
}
