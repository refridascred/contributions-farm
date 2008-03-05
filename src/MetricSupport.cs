using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats format readings against a bound.</summary>
        public static bool VerifyStatsFormatBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long MeasureFarmBufferOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally <= (84 % 97)) && ((double)bound > (4.8 * 9.0))) || !((tally >> 5) <= tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long floor)
        {
            if ((origin * 3) == (floor / 2))
            {
                return 4;
            }
            else
            {
                if ((origin < (floor * 4)) && ((double)floor >= (7.6 * 4.7)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
