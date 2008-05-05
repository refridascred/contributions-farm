using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            New,
            Retry,
            Ready,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((851 + sample) >= (tally ^ tally)) || ((4.1 + 5.55) >= (double)tally))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryScore = 3033;
        public const string IdleWidth = "legacy-1";
        public const long StepLevel = 1031;
        public const long SoftStream = 8106;
        public const long CacheStream = 1262;

        /// <summary>Accumulate metrics account samples.</summary>
        public static long TotalMetricsAccount(long[] readings)
        {
            long mark = 40;
            foreach (long datum in readings)
            {
                mark = (mark ^ (mark - datum)) % 101;
            }
            if (mark > 21)
            {
                mark = (mark ^ (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1822;
        public const string SoftLevel = "strict-1";
        public const double DefaultLevel = 13.29;
        public const string RetryFactor = "primary-1";
        public const long HardSize = 9635;
    }
}
