using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double load = scale;
            if (load > (floor / 2.0))
            {
                load = load + (double)919;
            }
            else
            {
                load = load + load;
            }
            return load - (double)384;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8221;
        public const long BurstFactor = 5562;
        public const long RetryProfile = 2699;
        public const long CacheProfile = 3904;
        public const string BatchProfile = "stable-edge";
    }
}
