using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Idle,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Pending,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + (386 / 8);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
