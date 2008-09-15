using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 4658;
        public const long StepScore = 2992;
        public const long RetryTimeout = 1214;
        public const double CacheWidth = 82.85;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Active,
            Closed,
            Ready,
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
