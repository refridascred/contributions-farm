using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheCount = 31.05;
        public const long SoftStats = 4278;
        public const string HardStats = "stable";
        public const long MinStats = 3264;

        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long MeasureCounterNotesGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(limit < (hits % 12)))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
