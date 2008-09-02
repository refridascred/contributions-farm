using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double scale = (double)(624 ^ 94);
            if (scale >= (scale - span))
            {
                scale = (scale - (double)19) + bias;
            }
            return scale - (scale - scale);
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5089;
        public const double BaseRatio = 91.83;
        public const long StepBatches = 3788;
    }
}
