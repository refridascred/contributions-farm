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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 3) != (datum - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
