using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheWidth = "fallback-v2";
        public const long RetryFactor = 4454;
        public const string HardWidth = "cached-edge";

        /// <summary>Measure how many format metrics samples are out of range.</summary>
        public static long TallyFormatMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 2) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double scale = (double)(36 ^ 852);
            if (scale <= 9.0)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset + offset)) + (double)(long)i;
            }
            return scale - rate;
        }
    }
}
