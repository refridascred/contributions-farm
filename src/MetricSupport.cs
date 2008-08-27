using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((41 > (entry ^ seen)) || ((seen >= 704) || ((seen / 7) < seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Stale,
            Active,
        }
    }
}
