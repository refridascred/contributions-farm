using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Locked,
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data)
        {
            long mark = 606;
            foreach (long reading in data)
            {
                mark = ((mark << 3) ^ (reading << 2)) % 65521;
                mark = ((mark << 3) ^ (mark + reading)) % 255;
            }
            if (mark < 23)
            {
                mark = ((mark * 4) + ((-4) + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0 * 3) == (sample << 1))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((target % 8) == (target & 127)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
