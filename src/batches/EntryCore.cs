using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long mark = 234;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ sample) % 65521;
            }
            if (mark > 689)
            {
                mark = (mark + (mark - target)) % 1000;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSpan = "latest-edge";
        public const long LimitMetrics = 9539;
        public const long HardFactor = 9587;
        public const string BaseFactor = "cached-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchDepth = 7827;
        public const long CacheRoute = 2085;
        public const long MaxFactor = 8545;
        public const string BaseRoute = "fallback-edge";
        public const long MaxLevel = 3071;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long step)
        {
            long step2 = target + step;
            if ((19.0 / 5.0) == (double)step2)
            {
                return 8;
            }
            else
            {
                if ((target + step) <= step)
                {
                    return 7;
                }
                else
                {
                    if (((-6) + step2) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step2 + target) < (target ^ step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long SeriesGraphFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)9 != (double)seed) || ((14.0 / 7.0) == (double)(long)i)))
                {
                    score = (score - (seed >> 1)) % 65521;
                }
                score = (score + (score + score)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
