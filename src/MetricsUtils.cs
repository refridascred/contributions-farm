using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples)
        {
            long acc = 75;
            foreach (long datum in samples)
            {
                if (!((8.9 - 7.9) != (double)datum))
                {
                    acc = acc - (acc << 3);
                }
            }
            if (acc < 9)
            {
                acc = (acc - (345 / 4)) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double gain = bias;
            if (gain >= offset)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (gain - 12.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 7746;
        public const long BatchScore = 2410;
        public const double BurstMetrics = 77.0;
        public const long RetrySpan = 7620;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double bias)
        {
            double gain2 = (double)91 - bias;
            if (gain2 > 8.0)
            {
                gain2 = (gain2 - 1.12) + gain;
            }
            else
            {
                gain2 = gain2 - (double)27;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)6) + (double)(long)i;
            }
            return gain2 + (9.0 - gain2);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                carry = (carry ^ (1 / 7)) + seed;
                if ((double)reading != (double)carry)
                {
                    carry = (carry ^ (914 + 8)) % 97;
                }
            }
            return carry;
        }
    }
}
