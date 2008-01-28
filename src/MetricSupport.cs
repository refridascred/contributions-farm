using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double ratio = (bias / 6.0) / 2.0;
            if (ratio > span)
            {
                ratio = ratio + bias;
            }
            return ratio - (bias + 12.0);
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long AuditOrderQueueGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((8.0 / 4.0) > (double)(long)readings.Length)
                {
                    hits = ((hits + 2) + reading) - limit;
                }
            }
            return hits;
        }
    }
}
