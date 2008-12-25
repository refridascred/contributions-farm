using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell + count) > cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (8.2 >= (double)tally)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
