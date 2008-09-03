using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((20 - seen) < (seen & 15)) && ((double)seen < (19.0 + 11.0)))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(((long)levels.Length - item) == (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long WeighContextCache(long[] samples, long origin)
        {
            long anchor = 431;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (24 * 5)) % 4096) - sample;
                if ((double)origin != (11.0 / 7.0))
                {
                    anchor = (anchor << 2) ^ (anchor + 828);
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ origin) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of command tools readings.</summary>
        public static long CombineCommandTools(long[] readings, long bound)
        {
            long total = 15;
            foreach (long sample in readings)
            {
                total = ((((total * 3) + (total / 3)) % 1000) + sample) - bound;
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + tally) != (long)levels.Length)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
