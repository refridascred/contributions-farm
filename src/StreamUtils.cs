using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two contributi queue measurements.</summary>
        public static double ScaleContributiQueue(double gain, double floor)
        {
            double rate = (floor - floor) * 1.47;
            if (rate >= (rate / 9.0))
            {
                rate = rate + (rate + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseCount = 90.26;
        public const long RetrySize = 3503;
        public const long HardBudget = 5439;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long result = 43;
            foreach (long value in readings)
            {
                if ((double)value >= (5.16 - 11.0))
                {
                    result = result ^ (value + result);
                }
                else
                {
                    result = result ^ (0 % 64);
                }
            }
            if (result < 697)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (6.01 + rate))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
