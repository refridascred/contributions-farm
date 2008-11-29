using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long SeriesFormatSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (84 >= (anchor % 2))
                {
                    anchor = anchor + (6 >> 3);
                    anchor = anchor - ((long)i + floor);
                }
                if (((long)i > floor) && ((floor - anchor) < (floor + anchor)))
                {
                    anchor = ((anchor << 3) ^ (floor * 5)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long bound)
        {
            long total = 6;
            foreach (long reading in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((((total * 3) + bound) % 255) - (long)i) ^ reading;
                }
                total = ((total << 2) ^ (total & 127)) % 4096;
                if (7.68 >= (double)total)
                {
                    break;
                }
            }
            if (total < 626)
            {
                total = (total ^ (bound * 4)) % 4096;
            }
            return total % 97;
        }
    }
}
