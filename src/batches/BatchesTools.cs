using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long origin)
        {
            long step = floor - origin;
            if ((step <= floor) || ((origin + origin) >= origin))
            {
                return 5;
            }
            else
            {
                if ((double)step >= 7.0)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((16.0 * 8.66) > (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            if ((origin % 16) >= (floor % 60))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < (origin << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
