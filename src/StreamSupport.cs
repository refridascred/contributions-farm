using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already metrics samples.</summary>
        public static long ScoreAlreadyMetrics(long[] levels, long target)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (((anchor - (anchor - anchor)) % 1000) - entry) - target;
            }
            return anchor;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 5241;
        public const double HardBudget = 81.26;
        public const long CacheContributi = 3700;
        public const double WindowContributi = 20.75;
    }
}
