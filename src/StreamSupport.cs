using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double bias = ratio + (double)7;
            if (bias < floor)
            {
                bias = bias + (double)724;
            }
            else
            {
                bias = bias + floor;
            }
            return bias + ratio;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data)
        {
            long mark = 14;
            foreach (long value in data)
            {
                if (((double)value == (double)mark) || (mark <= (value - mark)))
                {
                    mark = ((mark << 3) ^ 636) % 65521;
                }
            }
            if (mark < 0)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long RollOrderCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
