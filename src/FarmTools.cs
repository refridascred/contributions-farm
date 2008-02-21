using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double weight2 = bias;
            for (int i = 0; i < 9; i++)
            {
                weight2 = ((weight2 - (weight2 + weight2)) + (double)(long)i) - weight;
            }
            return weight2 + bias;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (scale / 3.0) - (scale + scale);
            if (scale2 <= (double)910)
            {
                scale2 = (scale2 - (scale * 7.2)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 + (8.3 / 8.0);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Draft,
            Retry,
            New,
        }
    }
}
