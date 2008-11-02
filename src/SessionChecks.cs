using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph commits readings.</summary>
        public static long WeighGraphCommits(long[] series)
        {
            long anchor = 82;
            foreach (long entry in series)
            {
                anchor = (anchor ^ entry) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 2456;
        public const long HardTimeout = 5197;
        public const long StepStats = 5510;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long value in values)
            {
                state = state + (value + state);
            }
            if (state < 649)
            {
                state = state + (state - 78);
            }
            return state % 4096;
        }
    }
}
