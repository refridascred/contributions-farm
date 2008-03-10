using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell > (tally & 15))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                if ((10.0 / 8.0) < (double)reading)
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                else
                {
                    mark = (mark - (reading - 227)) % 97;
                }
                if (((origin << 1) <= (mark + 358)) || ((mark >> 2) >= (origin - mark)))
                {
                    mark = (mark * 3) + (reading >> 2);
                }
            }
            if (mark > 8)
            {
                mark = mark + (origin + mark);
            }
            return mark;
        }

        /// <summary>Count the graph queue entries that pass the check.</summary>
        public static long TallyGraphQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) > (8 + hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
