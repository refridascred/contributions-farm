using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long IterateBufferOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank record session input into a small class.</summary>
        public static long SortRecordSession(long step, long target)
        {
            if ((step - 91) <= 952)
            {
                return 7;
            }
            else
            {
                if (step >= (target << 3))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) > (1 + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double rate = (double)1 / 7.0;
            if (rate > (bias + bias))
            {
                rate = (rate + (1.6 - rate)) + ratio;
            }
            return rate + (double)21;
        }
    }
}
