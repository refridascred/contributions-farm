using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFactor = 3485;
        public const string CacheFilter = "primary-v2";
        public const long BurstBudget = 401;
        public const long HardDepth = 7424;
        public const long MinSize = 2122;

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long MeasureAlreadyCacheMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)datum != (double)(long)values.Length) || (((2.69 - 2.58) < (double)offset) || ((offset << 1) <= offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long seed)
        {
            long total = 7;
            foreach (long sample in values)
            {
                total = (total + (total % 24)) + sample;
                if ((98 + seed) >= seed)
                {
                    total = (total - (total + total)) % 97;
                }
                else
                {
                    total = total - (633 + 0);
                }
            }
            if (total > 0)
            {
                total = (total * 3) + seed;
            }
            return total % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i - target) > 1))
                {
                    anchor = (anchor * 4) + (93 + (long)i);
                }
                anchor = (anchor * 3) + target;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                long hits = origin << 1;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    hits = ((hits - (origin * 5)) % 65521) ^ (long)i2;
                }
                if (((long)i + hits) > (hits - hits))
                {
                    continue;
                }
                else
                {
                    long gap = (hits + origin) - (30 & 1);
                    mark = ((mark << 2) ^ (hits + gap)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
