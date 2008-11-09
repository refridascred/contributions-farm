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

        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long CountWindowMetricGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)matches < (double)origin) && (sample < (5 ^ sample)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
