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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long offset)
        {
            if (((offset >> 3) < ((-2) ^ offset)) && (offset > seed))
            {
                return 0;
            }
            else
            {
                if ((3 + 316) > (offset / 7))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
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
