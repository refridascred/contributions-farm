using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum ^ seen) > seen) || (datum < (datum & 127)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 7.38;
        public const double LimitStats = 79.42;
        public const long MaxSize = 2005;
        public const long DefaultLevel = 6452;
        public const string WindowFactor = "local";

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
