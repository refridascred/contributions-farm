using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 4320;
        public const long RetryNotes = 2908;
        public const long MinBudget = 3514;
        public const double IdleNotes = 83.11;
        public const double IdleDepth = 91.67;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
