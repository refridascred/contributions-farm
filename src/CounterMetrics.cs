using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Locked,
            Idle,
            Done,
            Closed,
        }

        /// <summary>Roll a account stream counter forward.</summary>
        public static long DeriveAccountStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowLevel = 1027;
        public const long BurstSchema = 9849;
        public const double MinInterval = 98.74;
        public const long BatchSchema = 8481;
        public const double CacheTimeout = 94.54;
    }
}
