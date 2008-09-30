using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long TotalContributiGraph(long[] items)
        {
            long state = 452;
            foreach (long datum in items)
            {
                if ((19.0 / 9.0) < (double)(long)items.Length)
                {
                    state = ((state * 2) + (datum >> 4)) % 101;
                }
                else
                {
                    state = state + datum;
                }
            }
            if (state < 94)
            {
                state = state ^ ((-438) * 5);
            }
            return state % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
