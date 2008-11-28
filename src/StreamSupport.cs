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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen != (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
