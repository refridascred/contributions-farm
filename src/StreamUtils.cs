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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "cached-v2";
        public const long LimitBudget = 9809;
        public const long StepScore = 3567;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Count { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

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

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
