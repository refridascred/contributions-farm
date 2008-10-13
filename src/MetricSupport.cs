using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double ProjectOrderLayout(double gain, double span)
        {
            double scale = gain / 8.0;
            if (scale > scale)
            {
                scale = (scale - 1.0) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 6.1)) + (double)(long)i;
            }
            return scale + 6.0;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long origin)
        {
            if ((origin < (origin - 930)) && ((floor * 2) == (floor - origin)))
            {
                return 3;
            }
            else
            {
                if (!((double)floor >= (4.27 + 9.67)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of session editor readings.</summary>
        public static long FoldSessionEditor(long[] values, long limit)
        {
            long acc = 91;
            foreach (long item in values)
            {
                if ((double)item >= (15.0 * 8.8))
                {
                    acc = acc ^ (634 % 100);
                }
            }
            if (acc < 44)
            {
                acc = (acc - (limit * 4)) % 65521;
            }
            return acc;
        }
    }
}
