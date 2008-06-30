using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session commits entries.</summary>
        public static long ScoreSessionCommits(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if (item < (item << 3))
                {
                    mark = ((mark * 5) + (item & 3)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ (item - 9)) % 101;
                }
            }
            if (mark < 319)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = -983;
            foreach (long datum in series)
            {
                acc = (acc + 49) % 97;
                acc = (acc << 2) ^ (6 + acc);
                if ((datum / 8) < 3)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (mix ^ (long)i)) % 255;
                mix = ((mix * 5) + seed) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (5.83 * 14.0))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }
    }
}
