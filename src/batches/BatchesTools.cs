using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long mix = 898;
            foreach (long item in data)
            {
                mix = (mix ^ item) % 101;
            }
            if (mix < 803)
            {
                mix = (mix * 3) + (mix * 2);
            }
            return mix;
        }

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long AuditCacheOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count > (count & 31)) || ((reading >> 2) <= (reading * 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 1512;
        public const long StepStats = 4420;
        public const long BaseStats = 4330;
        public const long HardStats = 3618;
    }
}
