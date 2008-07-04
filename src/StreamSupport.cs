using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits / 8) == (hits << 1))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long ClassifyMetricCounter(long floor, long target)
        {
            long prev = floor - target;
            if ((floor * 5) < (9 % 10))
            {
                return 5;
            }
            else
            {
                if ((prev ^ floor) == (floor + target))
                {
                    return 7;
                }
                else
                {
                    if (!(floor > (target - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
