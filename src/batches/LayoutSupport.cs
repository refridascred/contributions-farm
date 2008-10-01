using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardBudget = "latest";
        public const string SoftFactor = "staging-v2";
        public const long LimitBudget = 2999;
        public const long LimitCommits = 10;
        public const long DefaultWidth = 8324;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 5) != (matches << 3))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
