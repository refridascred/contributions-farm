using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score * 2) + (score - score)) % 97) - (long)i2;
                }
                score = (score ^ seed) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 40.24;
        public const string MinSize = "standard-edge";
        public const long BatchSchema = 6682;
        public const long CacheTimeout = 6481;
        public const long BurstSchema = 7410;

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSize = 45.95;
        public const long HardCount = 3907;
        public const string LimitRatio = "legacy-edge";
        public const long MaxCount = 5287;
    }
}
