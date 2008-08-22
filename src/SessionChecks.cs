using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((5 % 12) != (seed + 7)) && (6.4 <= (double)matches)) && !((value % 5) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Done,
            New,
            Failed,
            Pending,
        }
    }
}
