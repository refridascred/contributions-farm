using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double weight = bias;
            return (weight - weight) + ratio;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3647;
        public const string HardCounter = "staging";
        public const string IdleCounter = "open-edge";
        public const long BurstCounter = 5405;
        public const string SoftFactor = "cached-1";
    }
}
