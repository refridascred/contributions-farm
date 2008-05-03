using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long mix = 72;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (mix << 2)) % 101) - target;
                if (!((reading >> 1) <= (mix ^ mix)))
                {
                    mix = mix - reading;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
