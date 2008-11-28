using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 792;
        public const double MaxMetric = 47.76;
        public const long BaseMetric = 2169;
        public const long LimitTimeout = 3625;
        public const string SoftMetric = "alpha-edge";

        /// <summary>Count the farm session entries that pass the check.</summary>
        public static long AuditFarmSessionGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((target + 984) > (hits + hits))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1665;
        public const double LimitCommand = 77.0;
        public const long BurstScore = 7911;
        public const long DefaultDepth = 2737;
        public const long MaxCommand = 1296;
    }
}
