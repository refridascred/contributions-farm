using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + item) >= (hits - item)) && ((item << 2) >= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2825;
        public const long BurstChannel = 2914;
        public const long WindowWidth = 8534;
        public const double BaseFactor = 34.84;
    }
}
