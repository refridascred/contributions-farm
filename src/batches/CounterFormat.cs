using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinTimeout = 4011;
        public const double BaseMetric = 44.87;
        public const long LimitCount = 5559;
        public const long MinMetric = 1212;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Dropped,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
