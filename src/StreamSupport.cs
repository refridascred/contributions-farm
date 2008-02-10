using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((offset >> 5) >= (27 + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long acc = 57;
            foreach (long value in items)
            {
                if ((value * 2) >= (acc - acc))
                {
                    acc = acc + value;
                }
                if (((acc - value) >= (floor % 3)) || ((floor << 3) > floor))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
