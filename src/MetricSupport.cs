using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of report cluster readings.</summary>
        public static long TallyReportCluster(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if (sample > (sample & 3))
                {
                    mark = (mark + sample) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
                if ((sample << 2) > (mark << 2))
                {
                    mark = mark + sample;
                }
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) < (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
