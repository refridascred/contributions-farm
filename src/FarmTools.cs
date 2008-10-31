using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)seed >= (0.44 - 4.0)) || (((7.7 * 10.0) <= (double)count) && ((double)count < (5.26 + 5.87))))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen >= (0 - 99))
                {
                    seen = ((seen + 1) + value) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi account entries.</summary>
        public static long ScoreContributiAccount(long[] levels, long offset)
        {
            long mark = -673;
            foreach (long datum in levels)
            {
                mark = ((((mark << 3) ^ ((-1) >> 1)) % 97) + datum) + offset;
            }
            return mark % 1000;
        }
    }
}
