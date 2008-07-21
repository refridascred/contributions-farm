using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Audit route already readings against a rule.</summary>
        public static long MeasureRouteAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(((sample / 8) >= (target & 63)) && ((count ^ count) == (84 - sample))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
