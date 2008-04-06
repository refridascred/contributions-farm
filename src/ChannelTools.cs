using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double rate = weight;
            if (rate > 8.0)
            {
                rate = rate - (bias / 9.0);
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (5.8 / 3.0);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Pending,
            Ready,
            New,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
