using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7290;
        public const long DefaultInterval = 7809;
        public const long BaseTools = 7084;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ (score >> 4);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 370;
        public const double BurstProfile = 44.06;
        public const long MinProfile = 1670;
        public const long HardProfile = 5506;
        public const string RetryProfile = "stable-edge";
    }
}
