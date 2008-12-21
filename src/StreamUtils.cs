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

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                acc = acc - (reading - reading);
            }
            if (acc < 69)
            {
                acc = acc + acc;
            }
            return acc;
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

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long sum = -6;
            foreach (long datum in readings)
            {
                sum = ((sum << 3) ^ (datum ^ datum)) % 1000;
            }
            return sum;
        }
    }
}
