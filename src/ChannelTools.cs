using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double bias = rate;
            if (bias < rate)
            {
                bias = bias + span;
            }
            return bias + (rate - bias);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 3449;
        public const string HardDepth = "local-1";
        public const long WindowDepth = 1706;
        public const long BaseSpan = 1811;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Pending,
            Ready,
            Retry,
        }
    }
}
