using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 977;
        public const double MinFormat = 28.34;
        public const double DefaultFormat = 62.91;
        public const string BatchLevel = "open";

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double drift = (double)(7 & 3);
            if (drift > (gain + span))
            {
                drift = drift + (gain - 8.8);
            }
            else
            {
                drift = drift - (double)3;
            }
            return drift - gain;
        }

        /// <summary>Classify a commits window pair into a bucket.</summary>
        public static long SortCommitsWindow(long limit, long offset)
        {
            if ((40 ^ offset) < offset)
            {
                return 8;
            }
            else
            {
                if (((-241) / 4) == (offset / 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
