using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCount = "latest";
        public const long CacheCount = 9339;
        public const long MinCommand = 5171;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 6586;
        public const long BatchScore = 1372;
        public const double BatchStats = 90.98;
        public const long DefaultStats = 6945;
    }
}
