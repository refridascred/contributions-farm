using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (origin + total)) % 65521;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinWidth = "open-1";
        public const long RetryCounter = 2232;
        public const double BurstCounter = 4.82;
        public const long StepCounter = 2007;
        public const long CacheDepth = 8174;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
