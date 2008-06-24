using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 <= scale2)
            {
                scale2 = scale2 + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (double)183) - (double)(long)i;
            }
            return scale2 + 0.3;
        }

        /// <summary>Accumulate profile contributi samples.</summary>
        public static long ScoreProfileContributi(long[] levels)
        {
            long result = 65;
            foreach (long sample in levels)
            {
                if ((18.0 - 5.7) != (double)result)
                {
                    result = (result * 5) + (sample % 5);
                }
                if ((sample + 29) <= (sample % 10))
                {
                    break;
                }
            }
            if (result > 594)
            {
                result = (result - (result % 100)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 560;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (-92)) ^ reading;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstRatio = 359;
        public const long IdleCounter = 2429;
        public const long DefaultCounter = 8094;
        public const double RetryTimeout = 1.39;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - 6.0) + (double)(long)i) + gain;
            }
            return bias + offset;
        }
    }
}
