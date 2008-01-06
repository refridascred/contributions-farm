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

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long CountContextFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((count * 5) <= 764))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
