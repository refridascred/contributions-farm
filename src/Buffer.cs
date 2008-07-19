using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (offset > (item - (-46)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((step & 31) < step) && !(((-580) - hits) < hits))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Failed,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
