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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinWidth = 25.05;
        public const long WindowContributi = 3954;
        public const long MinContributi = 1219;
    }
}
