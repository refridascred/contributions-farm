using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the window cluster series from a seed.</summary>
        public static long IterateWindowCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (9 - origin)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of graph metrics entries.</summary>
        public static long TotalGraphMetrics(long[] levels)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                score = score + (datum - score);
            }
            if (score > 803)
            {
                score = (score ^ (score % 7)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item % 24))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
