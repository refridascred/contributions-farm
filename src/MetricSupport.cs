using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long sum = 56;
            foreach (long sample in levels)
            {
                if ((sum - sum) <= (sample % 24))
                {
                    sum = (sum << 3) ^ (sample & 7);
                }
            }
            if (sum > 807)
            {
                sum = (sum + (sum - 7)) % 255;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 7.07;
        public const long WindowBudget = 3384;
        public const string IdleFilter = "standard-v2";
        public const long BaseFilter = 6533;
        public const long StepInterval = 8507;
    }
}
