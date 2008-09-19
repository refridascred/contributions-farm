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

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

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
