using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "standard";
        public const double MinAlready = 92.47;
        public const string HardAlready = "strict";
        public const string LimitAlready = "fallback-1";
        public const long SoftDepth = 9068;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit cluster route readings against a rule.</summary>
        public static long MeasureClusterRouteMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell + 63) > (target >> 3)) || (92 < (cell + cell)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
