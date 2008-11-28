using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Closed,
            Ready,
            Queued,
            Idle,
        }

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
