using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((4.9 / 6.0) > (double)limit))
                {
                    acc = (acc * 3) + (long)i;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long StepToolsOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2487;
        public const long BaseNotes = 945;
        public const double BurstNotes = 26.59;

        /// <summary>Check that every account cache entry stays within the limit.</summary>
        public static bool CheckAccountCacheLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}
