using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - mark;
                mark = mark + 4;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((double)carry <= (15.0 + 5.0))
                {
                    carry = (((carry << 2) ^ carry) % 255) ^ cell;
                }
            }
            if (carry < 29)
            {
                carry = (carry + (carry ^ carry)) % 97;
            }
            return carry;
        }

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
