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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
