using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long MeasureFormatAlreadyGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((16.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) - item) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Retry,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (7.86 > (double)entry)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
