using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < 15.0)
            {
                scale = (scale + (ratio * 18.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 4.8) + (double)(long)i;
            }
            return scale - (double)(-7);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 5566;
        public const long DefaultAccount = 6394;
        public const long BatchTimeout = 4031;
        public const long RetryAccount = 175;
        public const double LimitScore = 17.86;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double rate = weight - 11.0;
            if (rate > weight)
            {
                rate = (rate + (double)80) + floor;
            }
            else
            {
                rate = rate + (weight / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + 8.26) + (double)(long)i;
            }
            return rate - (7.9 * 18.0);
        }
    }
}
