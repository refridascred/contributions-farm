using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of githubfarm queue readings.</summary>
        public static long OverlapGithubfarmQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8450;
        public const double DefaultCache = 30.67;
        public const long RetryCache = 4085;
        public const long BaseSize = 3114;
        public const long StepSpan = 4216;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftCount = 2803;
        public const long IdleScore = 3412;
        public const long CacheRecord = 6229;
    }
}
