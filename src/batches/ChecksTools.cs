using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long MeasureLayoutMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (6.7 / 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Retry,
            Dropped,
            New,
            Closed,
        }
    }
}
