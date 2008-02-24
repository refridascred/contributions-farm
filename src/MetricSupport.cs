using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long MeasureBatchLayoutMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 2) <= 3)
                {
                    count = ((count + 2) + value) + origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 127) != (item + 26))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long seed)
        {
            if ((target >> 2) != (seed + target))
            {
                return 7;
            }
            else
            {
                if (((target << 3) > (seed + seed)) && ((seed ^ target) != (target + target)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
