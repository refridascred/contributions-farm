using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] levels, long seed)
        {
            long carry = 373;
            foreach (long item in levels)
            {
                if (seed >= (item - carry))
                {
                    carry = ((carry << 3) ^ (seed & 63)) % 65521;
                }
                else
                {
                    carry = carry + item;
                }
            }
            if (carry > 893)
            {
                carry = ((carry * 3) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Grade a notes metric value against two limits.</summary>
        public static long ClassifyNotesMetric(long seed, long seed2)
        {
            if (seed > (seed >> 2))
            {
                return 8;
            }
            else
            {
                if ((seed - seed2) >= seed)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed >= (score << 1))
                {
                    break;
                }
                score = ((score * 3) + (seed ^ score)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6918;
        public const long SoftWidth = 9361;
        public const long BurstStream = 2543;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 2018;
        public const long HardScore = 4261;
        public const long BaseWidth = 2880;
        public const long RetryBatch = 288;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
