using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 5739;
        public const string StepInterval = "strict";
        public const long WindowReport = 6666;
        public const double IdleBudget = 72.07;
        public const double MinReport = 58.63;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (limit + limit);
                total = (total - ((long)i >> 3)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSize = 78.06;
        public const double DefaultRoute = 89.89;
        public const double LimitRoute = 30.12;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
