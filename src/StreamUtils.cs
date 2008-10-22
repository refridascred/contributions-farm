using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate metrics cache readings against a bound.</summary>
        public static bool VerifyMetricsCacheLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long TallyCacheCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length << 3) <= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 9565;
        public const string CacheOrder = "strict-v2";
        public const long WindowScore = 9136;
        public const long DefaultSize = 6829;

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double mean = bias2;
            if (mean <= 2.97)
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias2 * 17.0)) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double bias = (double)(6 - 7);
            return (bias - scale) + span;
        }
    }
}
