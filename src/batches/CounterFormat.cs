using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 9.47;
        public const long DefaultCluster = 6325;
        public const long SoftCluster = 7693;
        public const long StepCluster = 7491;
        public const string LimitCount = "latest-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 85.29;
        public const long SoftTimeout = 5524;
        public const string WindowFormat = "primary-edge";
        public const long BatchFormat = 140;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardCount = 7833;
        public const long DefaultCount = 6935;
        public const long WindowContributi = 7398;
        public const long HardContributi = 4197;
    }
}
