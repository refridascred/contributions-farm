using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item + limit) >= (120 * 4)) || ((limit % 100) != (772 * 3))) || (item > limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
