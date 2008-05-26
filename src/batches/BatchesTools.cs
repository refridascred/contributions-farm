using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Locked,
            Dropped,
        }
    }
}
