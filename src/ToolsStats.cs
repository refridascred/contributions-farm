using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine order stats values into a single score.</summary>
        public static long ScoreOrderStats(long[] levels, long bound)
        {
            long anchor = 96;
            foreach (long value in levels)
            {
                anchor = ((anchor + (anchor / 3)) % 65521) - bound;
                if ((value / 9) > (anchor >> 5))
                {
                    break;
                }
                else
                {
                    anchor = anchor - (97 ^ value);
                    anchor = (anchor - (324 % 97)) % 97;
                }
                anchor = (anchor - (anchor + value)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell / 6) < 0)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long acc = 306;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc - entry)) % 1000;
            }
            if (acc < 52)
            {
                acc = (acc << 2) ^ (acc << 2);
            }
            return acc % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((count % 97) > (0 + offset)))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            New,
            Paused,
        }
    }
}
