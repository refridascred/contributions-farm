using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Queued,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample % 7) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryWidth = "cached-edge";
        public const string DefaultEntry = "fallback";
        public const long StepEntry = 3279;
        public const string MinEntry = "cached-1";

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally < (seed * 4)) && ((118 % 7) <= (tally << 2))) && ((value << 2) >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
