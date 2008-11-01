using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double bias = (double)(-702) * 19.0;
            if (bias <= (scale - scale))
            {
                bias = (bias + (bias / 7.0)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + 4.0;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            New,
            Queued,
            Draft,
        }

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool CheckGraphCounterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
