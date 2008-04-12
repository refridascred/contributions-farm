using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if ((double)origin != (3.0 / 5.0))
                {
                    mark = mark + item;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long prev = step + origin;
            if ((-36) > (step - prev))
            {
                return 0;
            }
            else
            {
                if ((step - prev) <= 74)
                {
                    return 3;
                }
                else
                {
                    if (origin > (prev ^ 601))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((950 + tally) >= (tally * 5))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
