using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order editor values into a single score.</summary>
        public static long DigestOrderEditor(long[] samples, long offset)
        {
            long result = -2;
            foreach (long cell in samples)
            {
                result = (((result * 4) + (692 - offset)) % 1000) + cell;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a session format sample.</summary>
        public static long LookupSessionFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 9153;
        public const long RetryMetric = 728;
        public const long LimitFactor = 9818;
        public const long IdleBudget = 8652;
    }
}
