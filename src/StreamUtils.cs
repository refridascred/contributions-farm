using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + item) > (7 - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Paused,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstInterval = "fallback";
        public const long BurstContext = 5423;
        public const long StepContext = 6656;
        public const string MinContext = "primary";

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 74.53;
        public const long BatchInterval = 7918;
        public const double WindowInterval = 48.61;
        public const string SoftStream = "fallback-edge";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            New,
            Dropped,
        }
    }
}
