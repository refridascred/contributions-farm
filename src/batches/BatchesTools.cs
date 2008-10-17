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

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values, long target)
        {
            long acc = -326;
            foreach (long value in values)
            {
                if ((acc * 4) > 6)
                {
                    acc = (acc ^ (649 >> 3)) + value;
                }
                else
                {
                    acc = acc + (acc - target);
                }
            }
            return acc % 65521;
        }
    }
}
