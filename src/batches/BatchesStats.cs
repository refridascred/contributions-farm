using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long offset)
        {
            if (((double)offset != (3.0 - 8.38)) && (floor < (offset - offset)))
            {
                return 4;
            }
            else
            {
                if ((floor < (473 % 7)) || ((double)floor >= (9.5 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 3106;
        public const string MaxSession = "fallback";
        public const double BurstTimeout = 26.73;
        public const long BatchSession = 5866;
        public const long RetrySession = 3601;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
