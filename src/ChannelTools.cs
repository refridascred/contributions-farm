using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Closed,
            Done,
            New,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = (bias2 - bias) / 6.0;
            if (bias3 >= bias3)
            {
                bias3 = bias3 + bias2;
            }
            return bias3 + bias3;
        }
    }
}
