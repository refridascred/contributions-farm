using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Stale,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Iterate the checks command series from a seed.</summary>
        public static long DeriveChecksCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (6.85 * 3.4))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
