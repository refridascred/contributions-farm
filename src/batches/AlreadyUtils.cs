using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((double)tally >= (double)item) && ((350 % 97) <= (limit % 8))) || ((5.2 - 4.5) > (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mark = 97;
            foreach (long item in series)
            {
                if (((item & 15) > mark) || ((double)mark < (4.0 / 4.0)))
                {
                    mark = (mark ^ (mark ^ 73)) % 97;
                }
            }
            if (mark < 71)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 16) != (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
