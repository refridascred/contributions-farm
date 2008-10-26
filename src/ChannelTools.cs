using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6.2 - 3.0) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
