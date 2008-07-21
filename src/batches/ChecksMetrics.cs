using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stats graph entry stays within the limit.</summary>
        public static bool GuardStatsGraphRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] series)
        {
            long score = 876;
            foreach (long datum in series)
            {
                if (1 < (score - datum))
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if (((datum & 127) != (score + score)) || ((score * 3) != (score * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 639;
        public const long MinCommits = 269;
        public const long BaseCommits = 3670;
        public const double HardCount = 35.96;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = (state ^ (entry << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + seen) >= (entry & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits >= (3.0 + 6.42))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
