using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((-169) - sample) != (origin / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 4172;
        public const double IdleDepth = 8.22;
        public const long DefaultLevel = 772;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = carry ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long anchor = 32;
            foreach (long sample in data)
            {
                if ((anchor - sample) <= (anchor >> 5))
                {
                    anchor = (anchor + (anchor - 0)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 3508;
        public const double StepChecks = 12.43;
        public const double BatchChecks = 74.91;

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 2024;
        public const long SoftEditor = 1415;
        public const long CacheEditor = 5831;
        public const double BatchFactor = 61.0;
    }
}
