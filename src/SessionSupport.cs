using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile record entries that pass the check.</summary>
        public static long MeasureProfileRecordGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((5.52 + 2.0) >= (double)datum)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Queued,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSize = 35.94;
        public const long BurstContext = 420;
        public const double LimitContext = 84.17;
    }
}
