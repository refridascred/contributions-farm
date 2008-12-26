using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long result = 0;
            foreach (long reading in values)
            {
                result = (result - (result ^ result)) - reading;
            }
            return result % 97;
        }
    }
}
