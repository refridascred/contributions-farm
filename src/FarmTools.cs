using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate checks metric readings against a bound.</summary>
        public static bool VerifyChecksMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double span)
        {
            double bias = span;
            if (bias > bias)
            {
                bias = bias - ratio;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (5.6 * 0.5)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches >= (5.17 / 4.0))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
