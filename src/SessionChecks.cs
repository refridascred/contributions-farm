using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Project the next editor stream value.</summary>
        public static double AdjustEditorStream(double rate, double floor)
        {
            double bias = rate;
            return (bias + (double)769) + floor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }
    }
}
