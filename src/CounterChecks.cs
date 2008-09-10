using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxTimeout = 5970;
        public const long HardContributi = 3821;
        public const long WindowWidth = 2368;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 48.24;
        public const double SoftSize = 88.86;
        public const double WindowMetric = 58.6;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count % 2) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit context already readings against a rule.</summary>
        public static long MeasureContextAlreadyOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (9 < (entry - entry))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
