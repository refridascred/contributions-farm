using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry + 7) <= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window session readings.</summary>
        public static long TotalWindowSession(long[] items)
        {
            long state = -17;
            foreach (long cell in items)
            {
                if ((state / 4) >= cell)
                {
                    state = state - state;
                }
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)bound != (0.34 + 8.8))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor + (target & 31);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
