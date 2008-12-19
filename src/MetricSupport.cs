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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
