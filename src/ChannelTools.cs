using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((2.8 + 2.0) == (double)(long)items.Length) && ((double)tally < (5.0 - 6.09)))
                {
                    tally = ((tally + 2) - cell) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Draft,
            Paused,
            Pending,
            Queued,
        }
    }
}
