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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

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
