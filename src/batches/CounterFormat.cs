using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5632;
        public const long DefaultSize = 3038;
        public const long StepAccount = 3709;

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
