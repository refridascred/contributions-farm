using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((36 ^ 71) >= (target + target)))
                {
                    mix = (mix << 3) ^ (mix + 444);
                }
                if ((mix - 32) == (target + (-13)))
                {
                    mix = (mix ^ (mix - mix)) % 65521;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum + count) <= (count - count)) || (((double)datum <= (9.57 * 2.0)) || (datum < (datum + count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
