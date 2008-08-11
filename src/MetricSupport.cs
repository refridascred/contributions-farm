using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long AuditRouteContextMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (limit >= (hits + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every token metrics entry stays within the limit.</summary>
        public static bool VerifyTokenMetricsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Stale,
            Idle,
            Done,
        }
    }
}
