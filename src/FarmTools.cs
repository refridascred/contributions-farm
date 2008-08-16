using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the route notes entries that pass the check.</summary>
        public static long AuditRouteNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches << 3) > matches) && ((reading + 2) != (matches & 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long offset)
        {
            long score = 960;
            foreach (long cell in values)
            {
                if (((-91) >> 3) <= (cell - (long)values.Length))
                {
                    score = (score ^ (offset + offset)) % 97;
                }
                score = (score << 3) ^ (offset - offset);
            }
            if (score > 828)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if (((sample + offset) > offset) && ((double)offset > (0.88 + 11.0)))
                {
                    mark = mark ^ (mark / 5);
                }
            }
            if (mark < 514)
            {
                mark = (mark * 4) + (offset + mark);
            }
            return mark;
        }
    }
}
