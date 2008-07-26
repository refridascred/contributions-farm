using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Adjust a token profile reading.</summary>
        public static double ScaleTokenProfile(double ratio, double offset)
        {
            double drift = (double)42 * 4.16;
            if (drift <= (4.44 / 3.0))
            {
                drift = ((drift - (drift / 9.0)) + ratio) - offset;
            }
            else
            {
                drift = drift + (double)(-22);
            }
            return drift - 3.4;
        }
    }
}
