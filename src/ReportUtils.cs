using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches >> 3) != (item & 63)))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((double)count <= (double)value) || ((count + 6) > value)) || ((9.04 - 4.4) < (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
