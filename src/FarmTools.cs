using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long acc = -513;
            foreach (long entry in items)
            {
                acc = (acc << 2) ^ (limit - acc);
                if ((limit * 5) == (entry ^ acc))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 8175;
        public const double CacheAlready = 75.45;
        public const long CacheBudget = 1609;
        public const double BurstSize = 38.46;
    }
}
