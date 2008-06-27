using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((5 + bound) >= (bound << 1))
            {
                return 4;
            }
            else
            {
                if (7.9 > (double)slot)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)0 < (double)slot) || ((seed + floor) > (seed - floor)))
            {
                return 5;
            }
            else
            {
                if (slot < (seed + floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + bound) != (bound * 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
