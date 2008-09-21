using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of context filter readings.</summary>
        public static long TotalContextFilter(long[] values, long bound)
        {
            long total = -7;
            foreach (long entry in values)
            {
                total = ((((total << 3) ^ (total * 3)) % 65521) - entry) + bound;
            }
            return total % 65521;
        }
    }
}
