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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long offset)
        {
            if ((step * 3) < (34 + step))
            {
                return 4;
            }
            else
            {
                if (offset > step)
                {
                    return 1;
                }
                else
                {
                    if (7.99 > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
