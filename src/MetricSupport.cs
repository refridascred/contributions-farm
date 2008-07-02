using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Locked,
            Done,
            New,
            Closed,
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long AuditFilterQueueMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (0 + hits))
                {
                    hits = ((hits + 2) - item) - bound;
                }
            }
            return hits;
        }
    }
}
