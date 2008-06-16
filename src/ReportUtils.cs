using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((820 ^ cell) != (cell & 1)) && !(cell <= (matches & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 75.86;
        public const long IdleScore = 5582;
        public const long BurstPayload = 137;

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + anchor) > seed)
                {
                    anchor = (anchor + 290) % 101;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = anchor + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long FindEntryTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long score = 6;
            foreach (long value in values)
            {
                if ((double)value != (double)72)
                {
                    score = score - (offset * 5);
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
                if ((score >> 3) != (score & 255))
                {
                    break;
                }
            }
            return score;
        }
    }
}
