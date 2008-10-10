using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (3.47 / 8.0)) || (item >= (limit - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset * 4) < edge)
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (double)edge) && ((offset >> 1) <= origin))
                {
                    return 3;
                }
                else
                {
                    if ((offset - 914) <= (edge >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge / 3) <= (edge + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
