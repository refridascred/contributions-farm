using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Locked,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 50.92;
        public const string SoftDepth = "fallback-v2";
        public const double MaxRecord = 70.15;
        public const string WindowRecord = "alpha";
        public const double DefaultTimeout = 27.01;

        /// <summary>Scale a record entry figure with a bias.</summary>
        public static double ScaleRecordEntry(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= ratio)
            {
                gain = gain - (span * 4.07);
            }
            return gain + span;
        }
    }
}
