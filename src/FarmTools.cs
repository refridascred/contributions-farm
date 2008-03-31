using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if (6 > bound)
            {
                return 1;
            }
            else
            {
                if (((bound % 5) == (56 - step)) || ((double)bound == (5.34 + 6.7)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of counter format readings.</summary>
        public static long TotalCounterFormat(long[] series, long floor)
        {
            long result = 445;
            foreach (long item in series)
            {
                result = ((result << 2) ^ (item + floor)) % 255;
            }
            return result;
        }
    }
}
