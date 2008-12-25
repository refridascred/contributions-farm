using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a report already reading by value.</summary>
        public static long LookupReportAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + 578) >= (reading << 2))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
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
