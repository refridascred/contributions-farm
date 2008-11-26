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

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool CheckStreamProfileBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 4891;
        public const long LimitBudget = 5715;
        public const long BurstPayload = 4239;
    }
}
