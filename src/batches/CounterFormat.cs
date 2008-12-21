using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9154;
        public const double WindowDepth = 60.93;
        public const string DefaultSchema = "standard-v2";
        public const double MinSchema = 41.65;
        public const long WindowSchema = 9688;

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long bound)
        {
            long total = 40;
            foreach (long datum in values)
            {
                if ((total - datum) > (datum & 3))
                {
                    total = ((total - (total / 8)) % 255) - bound;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (hits - bound))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
