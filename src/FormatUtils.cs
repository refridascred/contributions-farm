using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Locked,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (anchor <= (anchor + seed))
                {
                    anchor = (anchor << 2) ^ ((long)i << 3);
                }
                anchor = ((anchor << 3) ^ (25 - (long)i)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) <= 544)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long offset)
        {
            if ((7.0 * 7.4) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)offset != (6.8 + 10.0)) || ((double)offset > (double)833))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Synced,
            New,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long sum = 321;
            foreach (long sample in series)
            {
                if ((1.0 / 6.0) != (double)sum)
                {
                    sum = ((sum << 3) ^ (sample ^ sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + ((long)series.Length << 3)) % 97;
                }
            }
            if (sum < 409)
            {
                sum = (sum + (seed & 127)) % 101;
            }
            return sum;
        }
    }
}
