using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheDepth = 41.58;
        public const long BaseScore = 7598;
        public const long BatchFormat = 8651;
        public const long CacheWidth = 5642;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double mean = (double)176 * 2.39;
            if (mean >= mean)
            {
                mean = (mean + (mean * 19.0)) + rate;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (bias * 2.6);
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double gain = offset * 5.1;
            if (gain >= (double)456)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 8.6;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const double MinMetrics = 14.25;
        public const double SoftFactor = 70.78;
    }
}
