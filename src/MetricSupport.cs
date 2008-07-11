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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double drift = (9.19 * 9.21) - (span * 7.77);
            if (drift > 9.66)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - rate;
            }
            return drift - span;
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
