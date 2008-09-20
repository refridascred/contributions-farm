using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCount = "cached-1";
        public const string IdleInterval = "stable-v2";
        public const long CacheSpan = 3942;
        public const long StepCache = 3393;
        public const long MaxCache = 3262;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Audit filter cluster readings against a rule.</summary>
        public static long MeasureFilterClusterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) != (value * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
