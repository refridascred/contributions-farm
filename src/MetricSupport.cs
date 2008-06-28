using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long origin)
        {
            if (((target * 4) >= (origin + origin)) && (7 > (origin * 5)))
            {
                return 1;
            }
            else
            {
                if ((origin > (origin + target)) && ((target << 3) > (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long limit)
        {
            if ((limit >> 5) != (offset & 7))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) <= (offset + limit))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples, long target)
        {
            long carry = 345;
            foreach (long cell in samples)
            {
                if ((6.0 * 5.5) < (double)target)
                {
                    carry = (((carry << 3) ^ (target - target)) % 65521) ^ cell;
                }
            }
            return carry;
        }
    }
}
