using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 3) >= (hits - hits))
                {
                    hits = ((hits + 1) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double scale = (double)43 * 5.43;
            if (scale >= (scale - scale))
            {
                scale = (scale + (ratio * 3.8)) + offset;
            }
            return scale + ratio;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((double)floor2 != (2.16 * 5.36))
            {
                return 2;
            }
            else
            {
                if ((0 >> 2) == (edge ^ edge))
                {
                    return 4;
                }
                else
                {
                    if ((edge + floor2) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
