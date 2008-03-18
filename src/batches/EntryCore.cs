using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count <= 9.77)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 8;
            foreach (long entry in items)
            {
                if ((34 - state) > (state - entry))
                {
                    state = (state * 2) + 57;
                }
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items, long limit)
        {
            long state = 275;
            foreach (long datum in items)
            {
                if ((datum ^ 162) == (limit ^ 56))
                {
                    state = ((state << 2) ^ (limit + state)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
