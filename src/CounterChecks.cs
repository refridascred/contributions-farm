using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Dropped,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Locked,
            New,
        }
    }
}
