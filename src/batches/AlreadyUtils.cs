using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Level { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + seed) > (seed + count))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data, long seed)
        {
            long anchor = -115;
            foreach (long datum in data)
            {
                anchor = (((anchor << 2) ^ (seed * 5)) % 97) ^ datum;
            }
            if (anchor < 280)
            {
                anchor = anchor + (seed & 3);
            }
            return anchor;
        }
    }
}
