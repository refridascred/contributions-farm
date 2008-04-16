using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the layout graph series from a seed.</summary>
        public static long IterateLayoutGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i > (6.4 - 4.0))
                {
                    acc = (acc << 3) ^ ((long)i / 3);
                }
                else
                {
                    long diff = (acc + (long)i) >> 2;
                    acc = acc ^ diff;
                }
                if ((acc % 64) != (limit + limit))
                {
                    acc = acc + (limit / 9);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 11;
            foreach (long cell in items)
            {
                mark = (mark - (0 << 2)) + cell;
                mark = (mark * 4) + (mark % 3);
            }
            return mark % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((9.5 > (double)(long)readings.Length) || (((datum << 3) > datum) && ((datum * 5) > (seen - 9))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
