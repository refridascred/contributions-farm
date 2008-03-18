using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((16.0 + 3.27) != (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm schema value from a seed.</summary>
        public static long DeriveGithubfarmSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = mark ^ (origin + mark);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits >= (value & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics session entries.</summary>
        public static long FoldMetricsSession(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                anchor = (anchor - anchor) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor * 4) + (anchor + value)) - (long)i;
                }
                if ((24 <= (anchor & 255)) && ((584 * 2) >= limit))
                {
                    anchor = (anchor + (anchor + value)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
