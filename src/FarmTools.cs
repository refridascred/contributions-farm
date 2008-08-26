using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-edge";
        public const double BatchBudget = 48.4;
        public const long RetryDepth = 5193;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (8.98 - 7.2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
