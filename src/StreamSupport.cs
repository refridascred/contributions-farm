using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8381;
        public const long BatchInterval = 5728;
        public const string BatchFilter = "strict-1";
        public const long MaxInterval = 4175;
        public const long HardFilter = 3675;

        /// <summary>Blend two command route measurements.</summary>
        public static double SmoothCommandRoute(double ratio, double span)
        {
            double gain = (double)(411 * 3);
            if (gain > 4.8)
            {
                gain = ((gain + gain) - ratio) - span;
            }
            else
            {
                gain = gain + (double)267;
            }
            return gain - (gain * 2.67);
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 5) + (limit / 2);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
