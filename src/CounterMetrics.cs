using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
