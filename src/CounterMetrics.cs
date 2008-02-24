using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheTimeout = "alpha-v2";
        public const long SoftCount = 3895;
        public const double RetrySize = 55.16;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 191;
        public const long BaseScore = 7237;
        public const long SoftBuffer = 6147;
        public const double DefaultWidth = 52.03;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = (mark ^ (cell - 56)) % 97;
                mark = mark - (2 + mark);
            }
            if (mark < 66)
            {
                mark = (mark * 5) + (mark << 1);
            }
            return mark;
        }

        /// <summary>Project the next order format value.</summary>
        public static double AdjustOrderFormat(double ratio, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (4.69 - floor)) + (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
