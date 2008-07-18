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

        /// <summary>Derive the next context stream value from a seed.</summary>
        public static long DeriveContextStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ target;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
