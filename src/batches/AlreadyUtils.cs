using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long offset)
        {
            long result = 413;
            foreach (long cell in values)
            {
                result = ((result * 3) + cell) - offset;
            }
            if (result < 2)
            {
                result = ((result << 3) ^ (result - 77)) % 4096;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseInterval = 46.05;
        public const long CacheRatio = 9076;
        public const long IdleRatio = 8393;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values)
        {
            long mark = 355;
            foreach (long item in values)
            {
                mark = mark - (mark & 1);
                if ((item >= (item & 15)) && ((mark >> 5) < item))
                {
                    break;
                }
            }
            if (mark < 28)
            {
                mark = mark ^ (93 & 63);
            }
            return mark;
        }
    }
}
