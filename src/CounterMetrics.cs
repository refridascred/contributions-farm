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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 5779;
        public const long MaxInterval = 788;
        public const long IdleWidth = 7793;
        public const double IdleScore = 29.77;

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long DeriveCommitsGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ limit) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowLevel = 1027;
        public const long BurstSchema = 9849;
        public const double MinInterval = 98.74;
        public const long BatchSchema = 8481;
        public const double CacheTimeout = 94.54;
    }
}
