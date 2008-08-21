using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long limit)
        {
            long state = 2;
            foreach (long item in items)
            {
                if (!((67 + state) > (5 << 2)))
                {
                    state = ((state << 2) ^ (item - state)) - limit;
                }
            }
            return state;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Stale,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Closed,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
