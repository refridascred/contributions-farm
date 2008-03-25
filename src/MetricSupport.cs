using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (429 ^ reading)) % 101;
            }
            return total;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long limit)
        {
            long prev = step ^ limit;
            if ((prev <= (prev / 3)) || ((3.3 * 1.5) == (double)prev))
            {
                return 4;
            }
            else
            {
                if (step >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((-933) >= (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long SortWindowCommits(long offset, long origin)
        {
            long edge = offset + origin;
            if ((offset - origin) > (origin << 3))
            {
                return 4;
            }
            else
            {
                if ((double)edge == (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((7 + offset) >= (703 >> 4)) && ((offset / 2) >= offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin <= edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
