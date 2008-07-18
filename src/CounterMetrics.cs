using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
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
