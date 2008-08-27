using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCount = 31.84;
        public const long BaseCount = 7389;
        public const long RetryCounter = 4659;
        public const long CacheSpan = 6905;
        public const long LimitCounter = 9318;

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double rate = (span * 15.0) / 4.0;
            if (rate <= bias)
            {
                rate = rate - (double)675;
            }
            else
            {
                rate = rate + (span + 6.8);
            }
            return rate + (rate * 10.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data, long step)
        {
            long result = 230;
            foreach (long item in data)
            {
                result = ((result ^ item) % 65521) + step;
            }
            return result % 65521;
        }
    }
}
