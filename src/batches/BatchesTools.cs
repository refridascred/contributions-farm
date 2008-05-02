using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 24.83;
        public const long IdleScore = 6043;
        public const long StepLayout = 7129;
    }
}
