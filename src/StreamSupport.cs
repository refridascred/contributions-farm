using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count <= (4.72 / 5.0))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 2) + ((long)i >> 2)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
