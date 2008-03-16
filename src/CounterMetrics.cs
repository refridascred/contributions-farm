using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally * 3) <= cell)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (((double)961 <= (double)gap) || ((limit / 2) >= (origin / 7)))
            {
                return 5;
            }
            else
            {
                if (!((gap - gap) <= (gap * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 4) == (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (9.01 > (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
