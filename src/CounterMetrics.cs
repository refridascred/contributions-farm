using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 3850;
        public const long DefaultTimeout = 2633;
        public const string MaxSpan = "latest-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 186;
        public const long RetryStream = 6790;
        public const double MinLevel = 40.49;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Retry,
            Synced,
            Done,
        }
    }
}
