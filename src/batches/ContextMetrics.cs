using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((497 >> 3) == (sample + matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((limit + tally) <= (4 % 60))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
