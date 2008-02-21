using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                long offset2 = (mix - offset) + (6 + offset);
                if (offset2 > offset)
                {
                    offset2 = offset2 ^ (offset + (long)i);
                    continue;
                }
                offset2 = ((offset2 * 4) + (offset2 & 3)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally >> 2) < (4 ^ tally)) || (((3.77 / 7.0) >= (double)item) && ((tally + limit) >= (item + 28))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((245 - reading) >= reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long target)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if (((double)target >= (double)entry) && ((double)target > (4.2 / 5.0)))
                {
                    mix = (mix << 2) ^ target;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + target);
                }
            }
            return mix;
        }
    }
}
