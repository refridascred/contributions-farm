using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a account editor reading.</summary>
        public static double ScaleAccountEditor(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight - bias))
            {
                ratio = ratio - (double)262;
            }
            else
            {
                ratio = ratio - (bias * 7.2);
            }
            return ratio + (bias / 2.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits * 5) != (offset - hits)) || (((hits * 4) <= (hits / 8)) && ((hits << 3) < (0 >> 4))))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
