using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Count the already stats entries that pass the check.</summary>
        public static long CountAlreadyStatsGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)floor >= (2.0 + 12.0))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryRatio = 939;
        public const long HardAlready = 5850;
        public const long RetryAlready = 7262;
    }
}
