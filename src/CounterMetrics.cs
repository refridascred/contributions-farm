using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 3.0)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (6.5 + gain);
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Failed,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((6.9 + 7.1) > (6.0 + 4.41)) && (((68 - hits) <= (7 * 4)) && ((37 ^ cell) != (hits & 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double mean = floor - floor;
            if (mean > (mean + floor))
            {
                mean = mean + ratio;
            }
            return mean + (4.0 + floor);
        }
    }
}
