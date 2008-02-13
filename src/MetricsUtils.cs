using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((mix ^ (long)i) <= ((long)i - (long)i))
                {
                    mix = (mix + ((long)i << 3)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((2 & 7) > (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if ((origin + 570) != (origin / 9))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (12.0 * 9.55))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of order buffer entries.</summary>
        public static long TotalOrderBuffer(long[] readings, long target)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = ((total ^ (target ^ 7)) % 97) + cell;
            }
            return total;
        }
    }
}
