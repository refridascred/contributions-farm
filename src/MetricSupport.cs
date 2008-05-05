using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading <= (599 & 3))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long seed)
        {
            long anchor = 77;
            foreach (long value in series)
            {
                if ((value > (anchor * 4)) || ((11.0 - 0.94) == (double)value))
                {
                    anchor = (anchor ^ anchor) - seed;
                }
            }
            return anchor % 4096;
        }
    }
}
