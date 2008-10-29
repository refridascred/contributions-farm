using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double ratio2 = (double)(3 + 27);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - (double)93) + (double)(long)i) - ratio;
            }
            return ratio2 - (9.4 - span);
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long BucketChannelCache(long limit, long seed)
        {
            long bound = limit ^ seed;
            if (!((bound + bound) >= (seed >> 3)))
            {
                return 5;
            }
            else
            {
                if (((558 % 97) != (bound % 60)) && ((limit / 4) != (limit & 127)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5128;
        public const long BatchSupport = 4016;
        public const long StepDepth = 917;
    }
}
