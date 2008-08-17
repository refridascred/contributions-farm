using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count payload channel pairs that satisfy a relation.</summary>
        public static long MatchPayloadChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 7501;
        public const long BurstSize = 5520;
        public const long BaseCount = 330;

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long MeasureEntryStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
