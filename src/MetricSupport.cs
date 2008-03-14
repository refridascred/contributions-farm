using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double bias = (double)(2 >> 2);
            if (bias < (bias + span))
            {
                bias = (bias - (double)241) - gain;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + bias;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            Active,
            Synced,
            Retry,
            Locked,
        }
    }
}
