using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - tally) > (tally % 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
