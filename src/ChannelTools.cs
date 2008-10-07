using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (bias / 2.0))
            {
                drift = drift - drift;
            }
            return drift + bias;
        }
    }
}
