using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long TallyFormatSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum / 7) < (datum >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate tools farm readings against a bound.</summary>
        public static bool GuardToolsFarmLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
