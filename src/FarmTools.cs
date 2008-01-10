using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long origin)
        {
            if (origin < floor)
            {
                return 6;
            }
            else
            {
                if ((floor + floor) < origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first payload session entry that matches the target.</summary>
        public static long LookupPayloadSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 97) > 65)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
