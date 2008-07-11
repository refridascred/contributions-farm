using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double span)
        {
            double scale = (double)(12 & 127);
            if (scale >= scale)
            {
                scale = ((scale + scale) - bias) + span;
            }
            return scale + (double)(-421);
        }
    }
}
