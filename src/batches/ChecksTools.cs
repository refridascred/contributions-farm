using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                double load = (15.0 - 15.0) * 0.34;
                if (!((155 >> 3) <= (target - mark)))
                {
                    mark = (mark - target) % 65521;
                }
                else
                {
                    mark = (mark - (mark - mark)) % 4096;
                }
                if (!((load - load) < (double)mark))
                {
                    mark = (mark - (22 >> 2)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)bound >= (20.0 + 19.0)))
                {
                    mix = ((mix * 2) + ((long)i + bound)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double scale, double offset)
        {
            double scale2 = (double)(3 << 2);
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (scale2 - scale)) + (double)(long)i) - offset;
            }
            return scale2 - (double)355;
        }
    }
}
