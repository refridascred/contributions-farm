using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long origin)
        {
            if (!((floor + floor) > origin))
            {
                return 0;
            }
            else
            {
                if ((floor + origin) != (origin % 2))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] series)
        {
            long acc = 0;
            foreach (long item in series)
            {
                if (((2.47 * 4.88) == (double)item) || ((0.4 + 3.2) >= (double)item))
                {
                    acc = (acc - acc) % 101;
                    acc = (acc * 3) + (item - 37);
                }
                if (6.65 < (double)acc)
                {
                    acc = (acc ^ (acc / 8)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9118;
        public const long IdleOrder = 1534;
        public const long HardSpan = 5882;
        public const long LimitOrder = 755;

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series, long limit)
        {
            long sum = -4;
            foreach (long cell in series)
            {
                sum = sum - (35 + limit);
                if ((cell >= 43) || (88 < (long)series.Length))
                {
                    break;
                }
            }
            if (sum < 859)
            {
                sum = (sum << 2) ^ (117 + limit);
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings, long offset)
        {
            long anchor = 22;
            foreach (long datum in readings)
            {
                if ((78 >= anchor) || ((double)offset > (6.0 / 6.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 16)) - datum;
                }
            }
            return anchor;
        }
    }
}
