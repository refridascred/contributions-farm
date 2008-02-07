using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batch route entries that pass the check.</summary>
        public static long AuditBatchRouteOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((-66) ^ cell) != (origin + 305))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster layout readings against a rule.</summary>
        public static long AuditClusterLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (98 >= (item << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
