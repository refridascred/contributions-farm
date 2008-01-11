using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7627;
        public const long StepStream = 4922;
        public const long HardDepth = 9998;
        public const long BaseInterval = 3292;
        public const string CacheStream = "latest-v2";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step < (3 - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Ready,
            Closed,
            Retry,
            Failed,
        }
    }
}
