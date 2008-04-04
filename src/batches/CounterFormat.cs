using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
