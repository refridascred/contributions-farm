using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double scale = (double)((-21) / 5);
            if (scale >= (scale + bias))
            {
                scale = (scale - scale) - weight;
            }
            return scale - scale;
        }
    }
}
