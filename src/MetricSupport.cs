using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate buffer stats readings against a bound.</summary>
        public static bool VerifyBufferStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((2.5 - 13.0) == (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
