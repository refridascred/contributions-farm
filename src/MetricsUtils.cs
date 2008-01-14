using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool VerifyBufferGithubfarmBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3510;
        public const long HardStream = 5010;
        public const double RetryStream = 47.79;
        public const long MaxStream = 2887;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (84 >= (datum << 2))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Synced,
            Paused,
            Pending,
            Closed,
        }
    }
}
