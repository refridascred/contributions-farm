using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 90.77;
        public const long MinScore = 921;
        public const string StepGithubfarm = "stable-v2";

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long state = 16;
            foreach (long reading in values)
            {
                if (((long)values.Length + reading) > (offset & 1))
                {
                    state = (state << 2) ^ (reading << 2);
                    continue;
                }
                state = ((state << 2) ^ offset) % 97;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 5634;
        public const long RetryRecord = 3608;
        public const long MaxRecord = 6499;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Pending,
            Retry,
            Locked,
        }
    }
}
