using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((double)lane >= (5.42 - 9.88))
            {
                return 8;
            }
            else
            {
                if ((bound % 10) <= (lane + bound))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 + 8.07) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate order route samples.</summary>
        public static long TotalOrderRoute(long[] readings, long target)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (!((target << 2) > (mark / 6)))
                {
                    mark = ((mark * 4) + target) - value;
                }
                else
                {
                    mark = mark ^ (1 * 4);
                }
            }
            return mark;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
