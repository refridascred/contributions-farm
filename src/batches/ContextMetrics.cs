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

        /// <summary>Roll a notes metric counter forward.</summary>
        public static long DeriveNotesMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry ^ (origin + carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
