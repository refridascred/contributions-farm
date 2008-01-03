using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MaxLevel = 11.38;
        public const double IdleSize = 56.39;
        public const long DefaultAlready = 5771;
        public const long RetryAlready = 1556;
        public const long RetryTimeout = 8860;

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
