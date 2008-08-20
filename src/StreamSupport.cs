using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((target + seen) >= (seen % 5))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double gain = 0.9;
            if (gain >= 18.0)
            {
                gain = ((gain - (double)480) - bias) - floor;
            }
            return gain + gain;
        }

        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long SortProfileStream(long seed, long target)
        {
            long delta = seed - target;
            if (!((delta << 2) == (target + 50)))
            {
                return 7;
            }
            else
            {
                if ((double)target > (6.2 - 14.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
