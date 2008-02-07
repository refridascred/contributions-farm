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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
