using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cluster report samples are out of range.</summary>
        public static long MeasureClusterReportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 2) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((97 - item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
