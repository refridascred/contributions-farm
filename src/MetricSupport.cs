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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (cell * 2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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
