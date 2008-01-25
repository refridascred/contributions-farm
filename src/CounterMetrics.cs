using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MinDepth = 63.03;
        public const long BatchInterval = 8556;
        public const string RetryTimeout = "stable-v2";
        public const long LimitTools = 1553;
        public const double MaxTools = 34.59;

        /// <summary>Combine cache batch values into a single score.</summary>
        public static long CombineCacheBatch(long[] levels, long offset)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if ((offset - 8) == (469 + cell))
                {
                    acc = (acc - (offset - offset)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches > (matches % 100)) || (((double)matches < (double)item) && ((double)item == (double)target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
