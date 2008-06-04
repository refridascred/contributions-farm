using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Closed,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 7763;
        public const long MaxInterval = 1416;
        public const double BatchLayout = 56.22;
        public const long BaseLayout = 2277;
        public const double MinRatio = 56.07;

        /// <summary>Rank payload stats input into a small class.</summary>
        public static long RankPayloadStats(long origin, long offset)
        {
            if ((double)offset < (1.9 - 4.22))
            {
                return 5;
            }
            else
            {
                if (origin >= (offset - origin))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
