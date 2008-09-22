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

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data)
        {
            long sum = 10;
            foreach (long value in data)
            {
                sum = (sum - (78 + sum)) % 255;
                if ((double)value > (1.79 * 3.37))
                {
                    sum = sum ^ (7 + sum);
                }
            }
            if (sum > 4)
            {
                sum = sum - (sum & 127);
            }
            return sum % 65521;
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
