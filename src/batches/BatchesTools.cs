using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = (ratio - ratio) + weight;
            }
            return ratio + (double)(-44);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((3.32 - 5.0) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (11 <= (step + (-659)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
