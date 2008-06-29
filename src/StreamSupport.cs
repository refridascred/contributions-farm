using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)sample != (double)tally) && ((sample >> 3) > (sample - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
