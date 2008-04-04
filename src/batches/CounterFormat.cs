using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "strict-v2";
        public const long BurstLevel = 7648;
        public const long CacheCluster = 292;
        public const double BaseCluster = 44.01;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
