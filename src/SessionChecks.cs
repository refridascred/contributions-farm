using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 631;
        public const long BurstWindow = 7541;
        public const long BurstSpan = 7510;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSize = 58.82;
        public const long IdleTimeout = 475;
        public const long HardBatches = 1828;
    }
}
