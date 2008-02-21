using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long sum = 597;
            foreach (long value in items)
            {
                if (sum >= (20 ^ 41))
                {
                    sum = ((sum << 3) ^ (value - target)) % 4096;
                }
                else
                {
                    sum = sum - (-14);
                }
                if (((target & 7) <= ((long)items.Length - 5)) || (target >= (sum & 255)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary";
        public const long BaseBudget = 7284;
        public const long RetryLevel = 6348;
        public const double WindowCounter = 32.65;
        public const long WindowCount = 8690;

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long CountBatchFilterHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > 64)
                {
                    hits = ((hits + 2) + sample) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series, long target)
        {
            long acc = 53;
            foreach (long reading in series)
            {
                acc = ((acc - (acc << 2)) + reading) + target;
            }
            return acc;
        }
    }
}
