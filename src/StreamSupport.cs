using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double ratio = (bias * 1.8) * 8.75;
            if (ratio >= (ratio * 1.33))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + ratio;
        }
    }
}
