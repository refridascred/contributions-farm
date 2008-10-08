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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = result + ((long)i * 4);
                if (!((double)result < (4.0 + 20.0)))
                {
                    result = (result - (bound + 49)) % 101;
                    result = result - (26 << 3);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
