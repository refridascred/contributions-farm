using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 37.02;
        public const double BatchToken = 81.05;
        public const double MinToken = 8.42;
        public const long SoftToken = 6162;
        public const string WindowToken = "open";

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
