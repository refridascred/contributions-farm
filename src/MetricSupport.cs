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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double bias = 0.8;
            if (bias <= (double)77)
            {
                bias = bias - span;
            }
            return bias - (1.0 - gain);
        }
    }
}
