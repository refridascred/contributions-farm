using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Blend two batch notes measurements.</summary>
        public static double BlendBatchNotes(double scale, double offset)
        {
            double drift = scale;
            return (drift - drift) + offset;
        }
    }
}
