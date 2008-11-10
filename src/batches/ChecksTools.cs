using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats payload counter forward.</summary>
        public static long SeriesStatsPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((6.73 / 4.0) == (double)origin)
                {
                    score = ((score << 2) ^ (892 * 2)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
