using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a layout commits reading by value.</summary>
        public static long LocateLayoutCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches / 3) == (matches % 16))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
