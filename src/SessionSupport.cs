using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSpan = 9488;
        public const string SoftQueue = "latest-v2";
        public const long SoftRatio = 1456;
        public const string BatchQueue = "primary";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double ratio = span;
            if (ratio < (weight - span))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (weight * 17.0);
        }
    }
}
