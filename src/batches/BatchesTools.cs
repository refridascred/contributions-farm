using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Queued,
            Failed,
            Ready,
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
