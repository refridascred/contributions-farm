using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstTimeout = "fallback-v2";
        public const long MaxSize = 8838;
        public const long StepCount = 3917;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 37.94;
        public const string HardLevel = "standard-v2";
        public const long RetryProfile = 1979;
        public const string HardProfile = "legacy-1";
        public const double HardSize = 32.6;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double load = ratio / 8.0;
            return (load + (load + load)) + offset;
        }
    }
}
