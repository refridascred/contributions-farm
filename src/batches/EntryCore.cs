using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 489;
        public const string BatchEditor = "fallback";
        public const double HardEditor = 88.94;
        public const long IdleInterval = 3854;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (0.2 - 1.04))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Retry,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor + (target << 3)) % 1000) - sample;
                if (((target >> 4) == (long)data.Length) || (397 <= (target / 2)))
                {
                    anchor = (anchor << 2) ^ (46 << 1);
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor % 65521;
        }
    }
}
