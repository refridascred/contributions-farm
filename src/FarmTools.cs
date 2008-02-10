using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long TallyMetricsSupportOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((seed <= (22 + count)) && ((seed + seed) != (count - count)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Scale a support batches figure with a bias.</summary>
        public static double AdjustSupportBatches(double weight, double span)
        {
            double bias = weight;
            if (bias < (weight * 7.0))
            {
                bias = (bias + bias) - span;
            }
            return bias + weight;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Paused,
            New,
        }
    }
}
