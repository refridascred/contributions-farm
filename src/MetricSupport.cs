using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value + value) <= (hits - 443)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long floor)
        {
            long lane = bound + floor;
            if (!((bound >> 1) < (lane + 95)))
            {
                return 2;
            }
            else
            {
                if (!((lane % 10) <= (bound ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((lane % 10) >= (142 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (lane << 3))
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
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series, long limit)
        {
            long mark = 86;
            foreach (long reading in series)
            {
                if ((7.9 / 3.0) > (double)reading)
                {
                    mark = (mark + (9 - reading)) - limit;
                }
                else
                {
                    mark = (mark << 3) ^ 86;
                }
            }
            return mark;
        }
    }
}
