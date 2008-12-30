using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchCount = "fallback";
        public const string LimitFarm = "alpha-v2";
        public const double RetryFarm = 82.96;
        public const long IdleFarm = 2710;
        public const long WindowFarm = 7416;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + (carry & 7)) % 97;
                carry = (carry << 3) ^ (carry / 6);
                if (!((long)series.Length != (7 - datum)))
                {
                    carry = ((carry << 3) ^ (carry >> 5)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum >> 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepSize = 23.76;
        public const string CacheLevel = "stable-edge";
        public const long MinReport = 6448;

        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long RollCounterContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
