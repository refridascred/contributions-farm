using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Queued,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 8410;
        public const long HardCount = 8685;
        public const long SoftCounter = 707;
        public const string RetryFactor = "strict-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4494;
        public const long WindowCache = 6383;
        public const long IdleCache = 8863;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long seed)
        {
            long sum = 4;
            foreach (long item in series)
            {
                if ((sum * 4) == (seed % 64))
                {
                    sum = sum ^ (140 + item);
                }
            }
            return sum;
        }
    }
}
