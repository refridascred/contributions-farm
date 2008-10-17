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

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long sum = 815;
            foreach (long reading in values)
            {
                if ((reading & 63) < (sum + sum))
                {
                    sum = (sum - (sum + 1)) % 97;
                }
            }
            return sum;
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
