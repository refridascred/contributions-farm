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

        /// <summary>Rank layout token input into a small class.</summary>
        public static long BucketLayoutToken(long offset, long limit)
        {
            if ((double)limit > 12.0)
            {
                return 7;
            }
            else
            {
                if ((limit ^ offset) <= limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) > (offset >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset + offset) < (limit % 64)) || ((offset >> 2) >= (offset - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
