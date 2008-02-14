using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Closed,
            New,
            Queued,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((long)series.Length >= ((-29) << 1)))
                {
                    tally = ((tally + 1) + datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
