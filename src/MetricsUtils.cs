using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long target)
        {
            long lane = limit + target;
            if ((limit % 12) < lane)
            {
                return 4;
            }
            else
            {
                if (((lane / 6) == (limit - 0)) || ((342 + target) <= limit))
                {
                    return 7;
                }
                else
                {
                    if ((0.7 - 2.0) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Idle,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 61.49;
        public const string WindowSpan = "standard-1";
        public const long DefaultBatch = 5018;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8506;
        public const double StepScore = 43.41;
        public const long RetryCommits = 9535;
        public const long BurstBudget = 3100;
        public const long MinCommits = 8292;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
