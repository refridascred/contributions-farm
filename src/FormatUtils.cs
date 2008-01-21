using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long mark = 42;
            foreach (long item in levels)
            {
                if (((double)9 < (double)item) || ((mark ^ 0) == (item << 2)))
                {
                    mark = (((mark * 3) + (87 + item)) % 4096) - step;
                }
                else
                {
                    mark = mark ^ ((long)levels.Length * 2);
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (step > (item << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Pending,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
