using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long TallyRecordSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (858 <= (hits ^ hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((total % 16) == (total * 5)))
                {
                    total = (total ^ origin) % 65521;
                    total = total ^ (total + origin);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total ^ (long)i) % 255) + (long)i2;
                    total = (total ^ (total / 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] data)
        {
            long total = 9;
            foreach (long item in data)
            {
                total = (total - item) % 65521;
            }
            return total;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values, long bound)
        {
            long result = 5;
            foreach (long item in values)
            {
                if (!((7.0 * 6.0) != (double)result))
                {
                    result = ((result + (bound - result)) % 97) ^ item;
                }
            }
            if (result < 84)
            {
                result = (result - (result - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = 827;
            foreach (long datum in items)
            {
                long offset = (anchor % 97) - datum;
                if (offset > (anchor + (-32)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    long edge = offset - (datum ^ anchor);
                    anchor = (anchor * 3) + (edge + edge);
                }
                if (((double)anchor < (18.0 * 1.1)) || (datum <= (datum + datum)))
                {
                    anchor = ((anchor * 3) + (datum * 4)) % 255;
                }
                else
                {
                    anchor = anchor - (anchor / 4);
                }
                if ((4.79 - 9.8) == (double)datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7918;
        public const long MinWidth = 1072;
        public const string BurstCommits = "open-edge";
    }
}
