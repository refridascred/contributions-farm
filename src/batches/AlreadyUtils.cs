using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long target)
        {
            long gap = offset - target;
            if ((target & 15) <= gap)
            {
                return 5;
            }
            else
            {
                if ((gap ^ offset) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((target + 3) > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long mix = 372;
            foreach (long datum in series)
            {
                if ((mix / 2) > mix)
                {
                    mix = (mix - (mix / 8)) + datum;
                }
                else
                {
                    mix = mix + (origin + 37);
                }
            }
            return mix;
        }

        /// <summary>Accumulate stream already samples.</summary>
        public static long FoldStreamAlready(long[] samples, long target)
        {
            long acc = 914;
            foreach (long cell in samples)
            {
                if ((cell - cell) <= target)
                {
                    acc = (acc ^ acc) % 65521;
                }
                else
                {
                    acc = (acc ^ ((long)samples.Length - acc)) % 97;
                    acc = (acc - (target - target)) % 4096;
                }
                acc = ((acc << 2) ^ (701 << 1)) % 255;
            }
            return acc;
        }
    }
}
