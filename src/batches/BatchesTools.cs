using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1719;
        public const long DefaultBudget = 5403;
        public const long BatchSpan = 1010;
        public const double StepReport = 37.57;

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long anchor = 74;
            foreach (long item in items)
            {
                anchor = ((anchor * 5) + item) % 255;
                anchor = anchor - item;
            }
            return anchor;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
