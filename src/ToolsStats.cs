using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long MeasureChecksReportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-546) - seen) <= 449)
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Queued,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long step)
        {
            long slot = floor - step;
            if ((0.4 / 7.0) > (double)step)
            {
                return 2;
            }
            else
            {
                if ((slot % 10) == (floor * 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long origin)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = (((acc * 4) + (entry - entry)) % 255) + origin;
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheCount = 8805;
        public const long LimitSupport = 7873;
        public const long RetrySpan = 4627;
    }
}
