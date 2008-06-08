using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)target < (double)2)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Draft,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items, long step)
        {
            long carry = 56;
            foreach (long value in items)
            {
                carry = ((carry ^ (step - 18)) % 4096) - value;
                carry = ((carry << 3) ^ (carry & 3)) % 65521;
            }
            if (carry < 1)
            {
                carry = carry ^ (carry - 9);
            }
            return carry;
        }
    }
}
