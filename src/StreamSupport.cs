using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (scale + weight))
            {
                scale = scale + (weight * 2.9);
            }
            return scale - (weight - scale);
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "alpha-1";
        public const string IdleFarm = "stable";
        public const long BaseTimeout = 6622;
    }
}
