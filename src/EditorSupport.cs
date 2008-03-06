using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + acc;
                acc = (acc + bound) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                if ((double)item >= (double)anchor)
                {
                    anchor = (anchor + (anchor + 455)) % 4096;
                }
                anchor = ((anchor << 3) ^ (item << 3)) % 4096;
                if ((item + item) <= (anchor * 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long bound)
        {
            long state = 67;
            foreach (long entry in samples)
            {
                if (((state ^ state) >= state) && (state > (state + bound)))
                {
                    state = ((state ^ (state % 100)) % 101) ^ entry;
                }
                else
                {
                    state = (state << 2) ^ (state - bound);
                }
            }
            return state % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
