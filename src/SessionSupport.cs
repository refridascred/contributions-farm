using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepWidth = 3336;
        public const string DefaultReport = "open-1";
        public const long MaxTimeout = 5082;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long offset)
        {
            long mark = 147;
            foreach (long cell in values)
            {
                mark = (((mark * 5) + (40 - mark)) ^ cell) - offset;
            }
            return mark;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Dropped,
            Paused,
            Done,
            New,
        }
    }
}
