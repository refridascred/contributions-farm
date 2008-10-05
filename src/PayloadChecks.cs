using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryDepth = 8398;
        public const string SoftTools = "stable-1";
        public const long BaseTools = 7673;
        public const long StepCount = 6031;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally >= (5.7 + 7.5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultWidth = "strict-1";
        public const string WindowDepth = "open";
        public const string IdleRecord = "alpha-1";
        public const long LimitRecord = 9823;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowInterval = "open";
        public const long BaseBuffer = 3448;
        public const long RetryBuffer = 3856;
        public const string CacheBuffer = "latest";
        public const long IdleBudget = 5048;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
