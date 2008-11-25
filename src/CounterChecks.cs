using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 6580;
        public const double CacheBudget = 26.57;
        public const string BasePayload = "open-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long carry = 498;
            foreach (long value in levels)
            {
                if (!((double)carry > 7.3))
                {
                    carry = carry + value;
                }
                if (((value / 6) == (carry & 15)) && ((value % 2) <= (value % 16)))
                {
                    carry = (carry ^ (value / 4)) % 4096;
                }
            }
            if (carry < 58)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3503;
        public const double WindowCluster = 34.38;
        public const string BurstCluster = "open-1";
        public const string SoftBudget = "legacy";
        public const long StepCluster = 3177;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long TallyContributiBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((1.06 / 2.0) >= (double)count) && ((value % 16) == ((long)samples.Length - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
