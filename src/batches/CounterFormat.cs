using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 4440;
        public const long BatchChannel = 8216;
        public const long BatchScore = 7133;
        public const long SoftSpan = 6813;

        /// <summary>Project the next graph farm value.</summary>
        public static double SmoothGraphFarm(double rate, double offset)
        {
            double rate2 = offset - 16.0;
            return (rate2 + (offset / 4.0)) + rate;
        }
    }
}
