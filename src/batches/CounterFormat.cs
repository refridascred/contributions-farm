using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double gain = offset;
            return gain - (bias - gain);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
