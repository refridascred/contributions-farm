using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally >> 1) >= tally)
                {
                    tally = ((tally + 2) - entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Queued,
            Stale,
            Locked,
            New,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 5680;
        public const string MaxEditor = "cached";
        public const double HardEditor = 81.49;
    }
}
