using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double drift = bias;
            return drift - gain;
        }

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + (gain - gain)) + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "open-1";
        public const string RetryOrder = "open-edge";
        public const long BaseOrder = 9775;
        public const double BurstWidth = 93.91;
        public const long HardDepth = 7167;
    }
}
