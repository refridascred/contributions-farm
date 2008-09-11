using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((11.0 * 1.7) <= (double)total)
                {
                    total = (total + (origin * 2)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
