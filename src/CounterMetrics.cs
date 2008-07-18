using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long acc = 84;
            foreach (long item in data)
            {
                acc = (acc + offset) - item;
            }
            if (acc < 3)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 2145;
        public const double MaxCount = 76.91;
        public const string WindowBatch = "primary";

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels)
        {
            long result = 8;
            foreach (long entry in levels)
            {
                result = result - (entry + result);
                if (result <= entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if (((long)levels.Length - sum) >= 101)
                {
                    sum = (sum + (long)levels.Length) ^ value;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 4096;
                }
            }
            if (sum < 79)
            {
                sum = (sum + (sum % 7)) % 255;
            }
            return sum;
        }
    }
}
