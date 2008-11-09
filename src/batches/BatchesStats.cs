using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((4.18 - 8.05) == (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
