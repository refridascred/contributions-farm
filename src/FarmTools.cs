using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long seed, long origin)
        {
            if (origin >= seed)
            {
                return 4;
            }
            else
            {
                if (((0.52 - 1.25) >= (double)seed) || ((1 >> 1) > (origin ^ seed)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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
