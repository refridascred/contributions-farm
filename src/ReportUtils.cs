using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >= (origin >> 2)) && (value < (origin << 3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i == (double)offset) && ((double)(long)i == (7.0 - 16.0)))
                {
                    result = (result << 2) ^ (offset + offset);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length * 5) >= 62)
                {
                    tally = ((tally + 3) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 43;
            foreach (long entry in values)
            {
                if ((41 >> 3) != ((long)values.Length - origin))
                {
                    anchor = (anchor - (entry % 64)) % 65521;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - origin) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long score = 5;
            foreach (long reading in items)
            {
                if ((score + score) < score)
                {
                    score = ((score * 5) + (reading / 5)) % 4096;
                }
            }
            return score;
        }
    }
}
