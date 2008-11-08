using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (77 << 3))
                {
                    matches = ((matches + 1) + sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1602;
        public const double SoftSupport = 78.99;
        public const double CacheSize = 0.62;
        public const long MaxSupport = 7585;
        public const double BaseSupport = 48.74;

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((3.9 + 5.49) <= (double)sum)
                {
                    sum = ((sum * 4) + (limit - sum)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (acc << 1)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)target >= (4.06 / 2.0)) || (((target >> 3) < (value - value)) || (((long)levels.Length & 15) > (679 & 15))))
                {
                    matches = matches + 3;
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
