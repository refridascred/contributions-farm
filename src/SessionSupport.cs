using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches > (origin - 647)) || !((matches ^ value) != (origin & 15)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 44.48;
        public const long HardScore = 7363;
        public const long BurstContext = 8989;
        public const string RetryContext = "open-1";
    }
}
