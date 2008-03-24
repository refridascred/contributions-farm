using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token contributi entries.</summary>
        public static long TotalTokenContributi(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                if ((state - reading) != (reading << 3))
                {
                    state = ((state * 4) + (reading ^ state)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (reading >> 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((seed <= (-876)) || ((86 ^ seed) <= (matches + seed)))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
