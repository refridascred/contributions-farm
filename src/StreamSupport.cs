using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 1.74))
            {
                weight = weight + (9.0 * 2.58);
            }
            return weight + (floor - gain);
        }
    }
}
