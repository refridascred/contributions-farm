using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 88.34;
        public const double HardTools = 93.08;
        public const string DefaultTools = "local-1";
        public const long LimitTools = 4184;
        public const double BurstTools = 88.02;

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double mean = 9.75;
            if (mean > 16.0)
            {
                mean = (mean - (double)746) - bias;
            }
            else
            {
                mean = mean - (rate - rate);
            }
            return mean + (double)25;
        }
    }
}
