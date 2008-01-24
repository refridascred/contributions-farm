using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 8952;
        public const long MinWidth = 971;
        public const string LimitLayout = "legacy";
        public const double CacheLayout = 91.07;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long total = 545;
            foreach (long cell in values)
            {
                if (total > (total - cell))
                {
                    total = total + (802 + cell);
                }
            }
            if (total > 0)
            {
                total = (total << 3) ^ (total << 3);
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - ((long)i - carry);
                if ((carry % 60) <= carry)
                {
                    carry = (carry ^ ((long)i & 7)) % 97;
                    carry = ((carry * 4) + (carry + (long)i)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a format entry pair into a bucket.</summary>
        public static long RankFormatEntry(long floor, long limit)
        {
            if (!((floor & 15) != (4 ^ limit)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor * 2) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
