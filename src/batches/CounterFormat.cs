using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 472;
        public const long HardSpan = 1908;
        public const double StepScore = 77.35;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Ready,
            Closed,
            Retry,
            Failed,
        }
    }
}
