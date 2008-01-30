using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 8816;
        public const double CacheRatio = 29.3;
        public const string RetrySupport = "stable-edge";

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long floor)
        {
            long carry = 35;
            foreach (long item in levels)
            {
                if (item >= (floor & 15))
                {
                    carry = carry - (floor - item);
                }
                else
                {
                    carry = (carry << 3) ^ (5 - floor);
                    carry = (carry + item) % 101;
                }
                if ((item + item) > (item + 0))
                {
                    carry = (carry + (742 * 5)) % 4096;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
            }
            return carry;
        }
    }
}
