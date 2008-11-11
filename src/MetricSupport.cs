using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Compare every pair of route metrics readings.</summary>
        public static long OverlapRouteMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double gain = 10.0;
            if (gain > bias)
            {
                gain = (gain - bias) - scale;
            }
            return gain + 1.0;
        }
    }
}
