using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.82 / 2.0) == (double)tally)
                {
                    tally = ((tally + 2) - datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                mark = (((mark * 3) + (mark - mark)) % 97) ^ cell;
            }
            if (mark > 3)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Active,
            Done,
            Paused,
            Closed,
        }
    }
}
