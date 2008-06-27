using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long step)
        {
            if ((double)step >= (double)15)
            {
                return 0;
            }
            else
            {
                if ((step - origin) >= (origin >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)step < (5.0 * 8.95)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits format entries.</summary>
        public static long TallyCommitsFormat(long[] data, long bound)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                if ((reading + anchor) > (anchor + bound))
                {
                    anchor = ((anchor * 3) + (reading + reading)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor / 7)) % 255;
                }
            }
            if (anchor < 847)
            {
                anchor = ((anchor * 2) + (anchor & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long PairTokenNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long MeasureStatsSupportHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((27 % 100) <= (datum + count)) || ((count * 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
