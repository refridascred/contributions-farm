using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (37 > (datum + matches))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long step)
        {
            long state = -8;
            foreach (long reading in items)
            {
                state = (state - (step ^ 79)) % 255;
                if ((31 >> 5) == (state * 3))
                {
                    state = (state << 2) ^ reading;
                }
                if (!((step & 1) <= (reading * 3)))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }
    }
}
