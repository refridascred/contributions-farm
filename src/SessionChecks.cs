using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long mark = 5;
            foreach (long reading in levels)
            {
                mark = (mark << 2) ^ mark;
                if (reading >= mark)
                {
                    mark = (mark + reading) % 101;
                }
            }
            if (mark < 237)
            {
                mark = (mark - (2 - 338)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Synced,
            Draft,
            Stale,
            Queued,
        }
    }
}
