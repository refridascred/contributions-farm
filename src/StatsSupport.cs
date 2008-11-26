using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit booking readings against a rule.</summary>
        public static long TallyBookingOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen > (seen & 1))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter counter input into a small class.</summary>
        public static long RankFilterCounter(long floor, long offset)
        {
            if ((floor - floor) < (235 ^ floor))
            {
                return 8;
            }
            else
            {
                if (offset <= (floor & 31))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit + mark) >= (mark / 4))
                {
                    mark = mark ^ (limit - (long)i);
                }
                if ((mark - (long)i) >= (limit / 7))
                {
                    mark = mark + (mark - 471);
                }
                else
                {
                    mark = (mark + ((long)i / 5)) % 101;
                }
                mark = ((mark * 5) + ((-17) - mark)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
