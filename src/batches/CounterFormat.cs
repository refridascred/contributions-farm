using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 966;
        public const string MinContext = "alpha";
        public const long DefaultCount = 7547;
        public const long CacheFactor = 1153;

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches context entries that pass the check.</summary>
        public static long AuditBatchesContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value % 3) >= ((-3) / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
