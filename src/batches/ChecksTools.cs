using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks support samples are out of range.</summary>
        public static long MeasureChecksSupportMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > hits)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long MeasureChecksEditorMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((4.79 + 9.61) != (double)item)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
