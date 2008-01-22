using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = mark - mark;
                if ((mark >> 4) == (limit % 100))
                {
                    continue;
                }
                else
                {
                    mark = mark + (356 - (-4));
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = (mark + mark) % 101;
                if ((cell ^ mark) < (604 ^ mark))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark << 3) ^ 38;
            }
            return mark;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Stale,
            Failed,
        }
    }
}
