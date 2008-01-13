using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 47.0;
        public const long MinScore = 9049;
        public const long BurstChecks = 8576;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)step > 9.2)
                {
                    total = ((total << 2) ^ (556 + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
