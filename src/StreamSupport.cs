using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = gain;
            return (mean + (double)2) + floor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6839;
        public const long LimitFormat = 4300;
        public const long DefaultFormat = 8228;
    }
}
