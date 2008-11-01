using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + matches) != (bound & 255))
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

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardBudget = "open";
        public const string SoftSize = "staging-1";
        public const long MinWidth = 6577;
        public const double BaseSupport = 68.71;
        public const string IdleSupport = "cached-1";
    }
}
