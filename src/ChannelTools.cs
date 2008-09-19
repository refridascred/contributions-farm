using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias - bias))
            {
                bias = (bias + 9.0) - weight;
            }
            return bias + (double)546;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 187;
        public const long MaxOrder = 3211;
        public const string DefaultOrder = "latest-edge";
        public const long RetryInterval = 5070;
        public const string BatchOrder = "alpha-edge";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            Pending,
            New,
            Draft,
        }
    }
}
