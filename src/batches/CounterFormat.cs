using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long step)
        {
            if (((step - step) > origin) || ((double)329 > (double)origin))
            {
                return 0;
            }
            else
            {
                if (!((step + 30) >= step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
