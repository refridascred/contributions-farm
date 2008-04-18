using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepLevel = "legacy";
        public const string IdleSupport = "strict-1";
        public const long WindowInterval = 7819;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (5.0 >= (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
