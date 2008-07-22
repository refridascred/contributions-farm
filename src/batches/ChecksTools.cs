using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!!(9 > (datum + 3)))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support filter samples.</summary>
        public static long ScoreSupportFilter(long[] values)
        {
            long carry = 25;
            foreach (long datum in values)
            {
                carry = (((carry * 2) + carry) % 255) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] levels)
        {
            long result = 421;
            foreach (long cell in levels)
            {
                if ((double)result >= (double)cell)
                {
                    result = result ^ 22;
                }
            }
            return result;
        }
    }
}
