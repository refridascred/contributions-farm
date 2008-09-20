using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double scale2 = span;
            if (scale2 >= 6.1)
            {
                scale2 = scale2 - (scale2 * 5.93);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - (double)(-303)) - (double)(long)i;
            }
            return scale2 - (scale / 6.0);
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a metric buffer counter forward.</summary>
        public static long IterateMetricBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (mark / 6)) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item >= 1)
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
