using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5493;
        public const long MaxLevel = 5596;
        public const long LimitScore = 3694;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
