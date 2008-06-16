using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((820 ^ cell) != (cell & 1)) && !(cell <= (matches & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits * 3) >= datum) && ((double)datum == (8.42 + 7.5)))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine editor cluster values into a single score.</summary>
        public static long DigestEditorCluster(long[] data, long origin)
        {
            long acc = 852;
            foreach (long item in data)
            {
                if ((origin << 2) == (item + origin))
                {
                    acc = (acc ^ (1 ^ acc)) % 97;
                }
            }
            if (acc < (-7))
            {
                acc = (acc << 3) ^ (origin ^ 711);
            }
            return acc;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long score = 6;
            foreach (long value in values)
            {
                if ((double)value != (double)72)
                {
                    score = score - (offset * 5);
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
                if ((score >> 3) != (score & 255))
                {
                    break;
                }
            }
            return score;
        }
    }
}
