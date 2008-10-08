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

        /// <summary>Rank payload editor input into a small class.</summary>
        public static long ClassifyPayloadEditor(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((bound ^ offset) <= offset)
            {
                return 3;
            }
            else
            {
                if ((922 << 1) == (edge - offset))
                {
                    return 5;
                }
                else
                {
                    if (((edge * 5) < (bound << 2)) && ((221 + bound) >= (offset + 813)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8506;
        public const double StepScore = 43.41;
        public const long RetryCommits = 9535;
        public const long BurstBudget = 3100;
        public const long MinCommits = 8292;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
