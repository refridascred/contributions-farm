using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long target)
        {
            long total = 876;
            foreach (long value in series)
            {
                if (target < (value + value))
                {
                    total = (total ^ (total % 16)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftDepth = 4.72;
        public const long BatchEntry = 9212;
        public const long DefaultDepth = 5995;
        public const string RetryEntry = "standard-v2";
        public const long StepEntry = 2030;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long carry = 90;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (item & 127)) % 1000;
            }
            return carry % 97;
        }
    }
}
