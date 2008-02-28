using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double mean = (double)977 + (double)6;
            if (mean < (mean * 1.83))
            {
                mean = (mean - (weight + 12.0)) + offset;
            }
            return mean - (mean * 5.4);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Ready,
            Active,
        }
    }
}
