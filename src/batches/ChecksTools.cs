using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean + 6.9) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
