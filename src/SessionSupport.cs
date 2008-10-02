using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)limit >= (6.0 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 7030;
        public const long CacheBudget = 5306;
        public const string BaseInterval = "cached-1";
        public const long BaseRecord = 3372;
    }
}
