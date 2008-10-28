using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long origin)
        {
            if (0.29 > (double)origin)
            {
                return 8;
            }
            else
            {
                if (origin > (origin + origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "legacy";
        public const string CacheRatio = "staging";
        public const string HardToken = "alpha";

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine buffer editor values into a single score.</summary>
        public static long FoldBufferEditor(long[] values, long limit)
        {
            long acc = -8;
            foreach (long value in values)
            {
                acc = ((((acc << 3) ^ (80 % 24)) % 1000) ^ value) + limit;
            }
            return acc % 65521;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((target + target) >= (bound + target))
            {
                return 8;
            }
            else
            {
                if (((target + target) != (target >> 1)) || ((target - target) >= target))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
