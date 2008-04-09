using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long floor)
        {
            long delta = bound ^ floor;
            if (7 >= (bound + bound))
            {
                return 1;
            }
            else
            {
                if (((5 & 255) >= delta) && ((delta + delta) > 90))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((8.05 / 2.0) > (double)value) || !((matches + value) <= value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 70.75;
        public const long BurstBuffer = 1705;
        public const long BurstInterval = 1932;
        public const long BurstRatio = 9542;
    }
}
