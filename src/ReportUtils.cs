using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7882;
        public const long BaseCache = 2077;
        public const double MinBudget = 75.12;
        public const long BatchCache = 4430;
        public const long DefaultCache = 8127;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((step >> 4) > step))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
