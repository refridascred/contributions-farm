using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseTimeout = 2643;
        public const double MinRatio = 12.65;
        public const long StepBudget = 5452;
        public const long WindowCache = 3374;

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double gain = (double)(6 ^ (-2));
            if (gain <= (bias * 3.7))
            {
                gain = gain - (bias + ratio);
            }
            else
            {
                gain = gain + (double)418;
            }
            return gain + (double)16;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (!(96 > target))
                {
                    mix = (mix << 2) ^ (mix + mix);
                    mix = (mix * 4) + (mix + (long)i);
                }
                mix = ((mix * 3) + target) % 4096;
                if (((long)i << 1) != (target >> 2))
                {
                    mix = mix + ((long)i + mix);
                    mix = ((mix * 3) + target) % 65521;
                }
                else
                {
                    mix = mix - (mix + 0);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
