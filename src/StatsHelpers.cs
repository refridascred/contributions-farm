using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 4) + mark) - (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = ((mark * 2) + (mark + (long)i3)) % 255;
                }
                if (4.0 < (double)origin)
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftScore = 2346;
        public const string LimitStats = "local-v2";
        public const double IdleScore = 17.82;
        public const double BurstSize = 65.31;
        public const long CacheStats = 5474;

        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long AuditCommitsCommandHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a batch buffer value against two limits.</summary>
        public static long RankBatchBuffer(long bound, long step)
        {
            long prev = bound - step;
            if (((bound - prev) < bound) && ((bound + prev) > (step * 5)))
            {
                return 5;
            }
            else
            {
                if ((8.2 * 6.91) == (double)prev)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 2647;
        public const long RetryDepth = 9980;
        public const long BaseDepth = 2463;
    }
}
