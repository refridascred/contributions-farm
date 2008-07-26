using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Blend two commits profile measurements.</summary>
        public static double ProjectCommitsProfile(double weight, double span)
        {
            double ratio = (double)(6 & 63);
            if (ratio > (span * 3.56))
            {
                ratio = ratio + weight;
            }
            return ratio - weight;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
