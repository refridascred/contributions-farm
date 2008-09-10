using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >= (94 / 9)) && (((2 + hits) < ((long)values.Length >> 2)) && ((hits + sample) <= (0 * 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ (anchor % 64)) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 5174;
        public const double LimitRatio = 34.54;
        public const double BurstCounter = 3.38;
        public const long MaxCounter = 5112;
        public const long RetryLevel = 6538;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (acc > (69 + 8))
                {
                    acc = (acc << 3) ^ ((long)i - acc);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
