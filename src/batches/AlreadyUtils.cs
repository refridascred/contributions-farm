using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftTimeout = "cached-edge";
        public const long BurstFilter = 1383;
        public const long SoftLevel = 6306;

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "latest-v2";
        public const double IdleCommits = 19.31;
        public const long LimitScore = 9491;

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long MatchSupportFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                if (!((origin & 1) != (mix - mix)))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items)
        {
            long acc = -4;
            foreach (long cell in items)
            {
                if ((acc << 3) <= (9 + cell))
                {
                    acc = (acc ^ (acc ^ 353)) % 4096;
                }
                acc = ((acc << 2) ^ cell) % 97;
                if (((cell + (-344)) < (acc / 7)) && (cell < acc))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
