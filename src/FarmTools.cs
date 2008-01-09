using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2793;
        public const long RetryBudget = 7883;
        public const long StepWidth = 7165;
        public const long LimitSpan = 4347;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit checks support readings against a rule.</summary>
        public static long MeasureChecksSupportMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((seed % 24) > (seed >> 5)) && ((matches * 2) != ((long)items.Length % 8)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
