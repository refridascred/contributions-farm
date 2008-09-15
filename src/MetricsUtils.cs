using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 2010;
        public const long IdleChannel = 1123;
        public const long RetryChannel = 9751;
        public const long HardLevel = 4861;
        public const long DefaultDepth = 1378;

        /// <summary>Combine already stats values into a single score.</summary>
        public static long CombineAlreadyStats(long[] readings)
        {
            long sum = -71;
            foreach (long value in readings)
            {
                if ((3.1 + 8.2) <= (double)value)
                {
                    sum = (sum + (value >> 4)) % 4096;
                }
                else
                {
                    sum = sum - (value + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)3)
            {
                rate = (rate + (double)67) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (3.7 - weight)) + (double)(long)i;
            }
            return rate + (double)82;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long limit)
        {
            long mix = 263;
            foreach (long value in values)
            {
                if (mix > (value / 5))
                {
                    mix = ((mix << 2) ^ (84 >> 2)) + limit;
                }
                else
                {
                    mix = mix - value;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "latest-v2";
        public const long StepCache = 979;
        public const long HardCache = 3626;
    }
}
