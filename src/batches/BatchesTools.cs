using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= (offset / 4.0))
            {
                scale2 = scale2 + offset;
            }
            else
            {
                scale2 = scale2 + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + offset;
        }
    }
}
