using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Accumulate batches editor samples.</summary>
        public static long TotalBatchesEditor(long[] series)
        {
            long mark = 26;
            foreach (long value in series)
            {
                if (((8 - value) >= (value + mark)) && ((mark + value) != (mark - value)))
                {
                    mark = (mark * 4) + (mark * 3);
                }
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((double)step2 <= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step2 - step2) > (step * 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}
