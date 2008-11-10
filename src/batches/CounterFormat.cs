using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double rate, double offset)
        {
            double weight = (double)(7 & 7);
            return (weight + (rate * 5.7)) + offset;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
