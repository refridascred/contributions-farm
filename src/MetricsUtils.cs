using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long limit)
        {
            long prev = target + limit;
            if ((2.4 <= (double)limit) || ((55 % 16) >= target))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (775 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)588 < (double)prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (prev >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long floor)
        {
            if (floor > bound)
            {
                return 5;
            }
            else
            {
                if (((bound * 3) > bound) || ((5.4 - 19.0) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (((floor + bound) < (36 / 5)) || ((bound - 155) == (floor & 31)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (seed % 10)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long target)
        {
            long carry = -6;
            foreach (long cell in values)
            {
                if ((double)carry <= (3.2 * 15.0))
                {
                    carry = (carry ^ (cell & 1)) - target;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of metrics notes entries.</summary>
        public static long FoldMetricsNotes(long[] data, long origin)
        {
            long mark = 0;
            foreach (long value in data)
            {
                if (((mark + origin) < (mark - value)) && ((mark - mark) > (value * 5)))
                {
                    mark = (mark ^ (origin - origin)) % 101;
                    continue;
                }
                if (!!((4.0 + 3.4) >= (double)mark))
                {
                    mark = ((mark << 2) ^ value) % 255;
                    mark = (mark ^ (mark % 12)) % 255;
                }
                if (!((4.65 * 2.7) != (double)value))
                {
                    mark = (mark * 3) + (origin % 12);
                }
                if ((value - mark) >= (origin & 127))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
