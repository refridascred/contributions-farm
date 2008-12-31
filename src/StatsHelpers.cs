using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every checks channel entry stays within the limit.</summary>
        public static bool VerifyChecksChannelLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowRatio = "staging-edge";
        public const string MinLayout = "strict-v2";
        public const long BaseLevel = 7673;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 3731;
        public const long BaseCache = 4455;
        public const long HardCache = 9023;
        public const long SoftScore = 9464;
        public const string WindowTimeout = "staging-edge";

        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double bias)
        {
            double scale = (double)9 * 1.0;
            if (scale >= (15.0 + bias))
            {
                scale = scale + (4.2 + rate);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - scale;
        }
    }
}
