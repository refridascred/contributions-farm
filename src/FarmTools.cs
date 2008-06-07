using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long RollCommitsFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every layout account entry stays within the limit.</summary>
        public static bool ValidateLayoutAccountLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstInterval = "alpha-edge";
        public const string CacheTimeout = "primary";
        public const long LimitSpan = 9482;
        public const double BaseCluster = 52.62;
        public const long CacheCluster = 2131;
    }
}
