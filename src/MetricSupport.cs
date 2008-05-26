using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)27)
            {
                ratio = ratio + (ratio * 6.9);
            }
            else
            {
                ratio = ratio + (gain + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio * 11.0)) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 2) + (-5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleInterval = "fallback-1";
        public const double MinBuffer = 44.02;
        public const string BatchDepth = "fallback-v2";
        public const long CacheBuffer = 2665;
        public const double LimitBuffer = 75.99;
    }
}
