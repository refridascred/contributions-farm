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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
