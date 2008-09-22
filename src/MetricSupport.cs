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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
