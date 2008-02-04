using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!!((double)item >= (6.0 + 2.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every commits cache entry stays within the limit.</summary>
        public static bool ValidateCommitsCacheLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long bound, long origin)
        {
            if (((double)origin > (6.3 * 0.23)) && ((origin ^ bound) <= origin))
            {
                return 6;
            }
            else
            {
                if (35 <= bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the support profile series from a seed.</summary>
        public static long RollSupportProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
