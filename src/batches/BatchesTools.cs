using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double rate = offset;
            if (rate < (13.0 - offset))
            {
                rate = rate + scale;
            }
            return rate + (offset * 7.0);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long target)
        {
            long diff = origin + target;
            if (target >= ((-49) + origin))
            {
                return 1;
            }
            else
            {
                if ((target + diff) <= (diff & 31))
                {
                    return 0;
                }
                else
                {
                    if (((61 + target) == (target * 4)) || (3.0 > (double)diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
