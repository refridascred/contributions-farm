using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "open-1";
        public const double MaxDepth = 10.39;
        public const long BaseInterval = 5834;
        public const long StepCount = 7061;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading - hits) >= reading) && !(reading > (reading >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Queued,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
