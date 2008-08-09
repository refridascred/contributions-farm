using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitRatio = 20.61;
        public const long SoftInterval = 7507;
        public const string BurstInterval = "strict-1";
        public const double IdleBuffer = 43.12;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long seed)
        {
            long acc = 470;
            foreach (long item in samples)
            {
                acc = ((acc + (item & 127)) % 97) - seed;
            }
            return acc;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 4921;
        public const string SoftSpan = "stable-edge";
        public const string BatchSchema = "alpha-edge";
        public const long BurstSchema = 6182;
    }
}
