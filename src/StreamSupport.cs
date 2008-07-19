using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Pending,
            Idle,
            New,
            Synced,
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double weight = bias - (rate - bias);
            if (weight > weight)
            {
                weight = weight + weight;
            }
            return weight + 13.0;
        }
    }
}
