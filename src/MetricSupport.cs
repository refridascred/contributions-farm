using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long state = 9;
            foreach (long value in readings)
            {
                state = ((state << 3) ^ step) - value;
            }
            return state % 4096;
        }

        /// <summary>Count the metric commits entries that pass the check.</summary>
        public static long TallyMetricCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((6.73 / 5.0) == (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long seed)
        {
            if ((seed & 63) < seed)
            {
                return 0;
            }
            else
            {
                if (((seed ^ seed) >= (7 * 4)) && ((step + step) >= (42 >> 5)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
