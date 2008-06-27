using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit >> 5) != (limit * 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) >= (item ^ item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            if (!(bound < (offset % 16)))
            {
                return 5;
            }
            else
            {
                if (offset >= (offset % 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ offset) == (offset ^ 44))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 8005;
        public const string LimitMetrics = "fallback";
        public const string StepLevel = "standard-v2";
        public const long StepTimeout = 2719;
    }
}
