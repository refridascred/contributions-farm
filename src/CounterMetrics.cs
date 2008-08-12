using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long origin)
        {
            long state = 122;
            foreach (long item in items)
            {
                state = (state - (origin % 10)) ^ item;
            }
            if (state > 313)
            {
                state = state ^ (state + 7);
            }
            return state % 1000;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Active,
            Draft,
            Idle,
        }
    }
}
