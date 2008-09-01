using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < (offset + offset))
            {
                rate2 = rate2 - (rate2 * 20.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - 9.75) + (double)(long)i;
            }
            return rate2 - (offset - rate);
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleBudget = 1151;
        public const string LimitCount = "staging-1";
        public const string MaxChecks = "staging-v2";
        public const double CacheChecks = 78.87;
    }
}
