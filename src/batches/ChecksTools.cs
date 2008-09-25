using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long prev = floor + bound;
            if ((double)bound < (double)prev)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) <= bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
