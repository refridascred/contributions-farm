using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (limit < matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache metric value.</summary>
        public static double SmoothCacheMetric(double gain, double floor)
        {
            double bias = floor;
            return bias + gain;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool GuardSchemaProfileBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
