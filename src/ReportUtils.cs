using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSpan = "fallback";
        public const long MaxBudget = 8409;
        public const string LimitLevel = "strict-1";
        public const string IdleRatio = "local-edge";
        public const long MaxBuffer = 2841;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Closed,
            Stale,
            New,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Idle,
            New,
            Closed,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Retry,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((45 % 97) > tally) || ((cell - 66) < (cell ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
