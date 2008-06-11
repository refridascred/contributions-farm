using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long anchor = -8;
            foreach (long cell in values)
            {
                if (((-6) + anchor) >= anchor)
                {
                    anchor = ((anchor + (anchor - anchor)) % 255) - cell;
                }
            }
            return anchor % 1000;
        }
    }
}
