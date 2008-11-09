using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long MeasureContextAccountHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((8.0 - 6.22) < (double)datum) || ((origin > (matches + origin)) || ((matches >> 4) > origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
