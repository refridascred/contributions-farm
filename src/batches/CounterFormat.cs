using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long target)
        {
            long next = step - target;
            if ((6 - 14) != (step + step))
            {
                return 5;
            }
            else
            {
                if ((double)next != (13.0 * 4.7))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 18.88;
        public const long CacheContributi = 32;
        public const string HardContributi = "stable-1";
        public const long DefaultTimeout = 472;
        public const double RetryFactor = 8.82;

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long CompareBatchesSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
