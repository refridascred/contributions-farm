using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long mix = 11;
            foreach (long datum in series)
            {
                if (!(((datum / 8) != (mix & 3)) || ((1.2 + 1.6) >= (double)datum)))
                {
                    mix = (mix + (mix + mix)) % 255;
                }
                mix = ((mix << 3) ^ (mix ^ datum)) % 97;
                mix = mix ^ (datum >> 2);
            }
            return mix;
        }

        /// <summary>Rank queue session input into a small class.</summary>
        public static long ClassifyQueueSession(long target, long limit)
        {
            if (((4.2 - 5.0) != (double)target) && ((target >> 4) == (target / 3)))
            {
                return 8;
            }
            else
            {
                if ((target << 2) <= target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)limit == (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(target >= 184))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long prev = origin - limit;
            if ((double)origin >= 2.42)
            {
                return 4;
            }
            else
            {
                if (!((1.2 * 8.5) > (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((prev * 3) <= (limit & 15))
                    {
                        return 8;
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
