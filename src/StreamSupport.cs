using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long anchor = 30;
            foreach (long sample in readings)
            {
                if ((9.94 * 3.7) < (double)anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor / 2)) - sample) - bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
