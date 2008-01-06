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

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double bias)
        {
            double gain = bias;
            if (gain <= (weight * 9.3))
            {
                gain = gain - (gain * 2.0);
            }
            return gain - (gain - weight);
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
