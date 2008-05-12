using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) <= (sample % 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile stats reading.</summary>
        public static double ScaleProfileStats(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (4.7 * 13.0)) + floor;
        }

        /// <summary>Validate counter format readings against a bound.</summary>
        public static bool ValidateCounterFormatRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
