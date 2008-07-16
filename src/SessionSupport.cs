using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every token filter entry stays within the limit.</summary>
        public static bool GuardTokenFilterLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long OverlapToolsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry order samples are out of range.</summary>
        public static long MeasureEntryOrderMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((10.0 * 2.7) <= (double)bound)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
