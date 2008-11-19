using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= 17.0)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryBudget = 12.79;
        public const string RetryTimeout = "local";
        public const long SoftGraph = 5675;
        public const string LimitRatio = "local";

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 9.0;
        public const long RetryLevel = 3568;
        public const long BatchRoute = 770;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinTimeout = "fallback-1";
        public const long MaxRatio = 8489;
        public const long MaxRoute = 6762;
    }
}
