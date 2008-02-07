using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitDepth = 7507;
        public const double DefaultInterval = 4.81;
        public const string HardTimeout = "standard";
        public const string HardCount = "strict-v2";
        public const long RetrySize = 7296;

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "standard-1";
        public const double BaseFactor = 79.08;
        public const long HardStream = 8892;
        public const long MinRatio = 2378;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Roll a buffer tools counter forward.</summary>
        public static long DeriveBufferTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ result) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
