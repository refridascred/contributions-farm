using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 2.0) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Done,
            Idle,
        }
    }
}
