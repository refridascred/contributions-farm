using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally / 6) == (tally << 2))
                {
                    tally = ((tally + 2) ^ item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
