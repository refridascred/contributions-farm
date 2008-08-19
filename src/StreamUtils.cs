using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long MeasureGraphContextMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((-582) + entry) >= hits)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (floor > ((long)series.Length << 3))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                mark = (mark * 5) + (5 + mark);
                if (value >= (1 % 2))
                {
                    mark = (mark + (mark - value)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((2.82 / 5.0) != (double)matches)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema account counter forward.</summary>
        public static long RollSchemaAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 3) ^ (floor - 0)) % 4096) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ (result & 1)) % 4096;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result ^ (origin & 1)) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
