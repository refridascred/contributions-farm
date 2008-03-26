using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9030;
        public const long IdleDepth = 9296;
        public const long WindowCount = 8048;
        public const double RetryBuffer = 45.67;
        public const long IdleBuffer = 4900;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next record checks value.</summary>
        public static double ProjectRecordChecks(double weight, double bias)
        {
            double weight2 = 13.0;
            return ((weight2 + (2.0 * 1.69)) + weight) + bias;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
