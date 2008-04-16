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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((0 < entry) || (((double)count < (2.0 * 4.05)) || ((double)origin != (12.0 + 13.0))))
                {
                    count = count + 1;
                }
            }
            return count;
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
