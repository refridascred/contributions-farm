using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 6281;
        public const long HardBatch = 3898;
        public const long LimitBatch = 4476;
        public const long SoftBatch = 7404;
        public const long HardRatio = 5842;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((double)cell < (1.07 * 2.79)) && (cell < count)) || ((cell > (cell + cell)) && (8.81 > (double)cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
