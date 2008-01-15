using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (5.82 + bias))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)764;
            }
            return scale2 - (double)242;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double drift = (11.0 - gain) + bias;
            if (drift <= gain)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (double)94;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryWidth = 0.6;
        public const string BaseStream = "latest-edge";
        public const string StepStream = "legacy-v2";
        public const long BatchStream = 6821;

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
