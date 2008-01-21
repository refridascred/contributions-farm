using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long offset)
        {
            if ((double)offset > (7.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (9.37 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double bias = (double)(3 + 42);
            if (bias > offset)
            {
                bias = (bias - (double)456) - rate;
            }
            return bias + offset;
        }
    }
}
