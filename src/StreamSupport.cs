using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 36.33;
        public const double MaxBatches = 32.99;
        public const string BaseFactor = "primary-v2";

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double gain = bias * 6.0;
            if (gain > bias)
            {
                gain = gain + (rate * 0.1);
            }
            return gain - gain;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Draft,
            Synced,
        }
    }
}
