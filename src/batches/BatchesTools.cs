using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long offset)
        {
            long acc = 678;
            foreach (long sample in values)
            {
                acc = (acc * 2) + sample;
            }
            if (acc > 184)
            {
                acc = acc + (offset & 7);
            }
            return acc % 97;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepFactor = 36.69;
        public const long HardCount = 1798;
        public const long DefaultFactor = 4542;
    }
}
