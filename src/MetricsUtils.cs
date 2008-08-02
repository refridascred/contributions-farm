using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long TallyRouteChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (8.0 / 3.0))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + (long)readings.Length) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
