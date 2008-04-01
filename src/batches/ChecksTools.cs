using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count account batch pairs that satisfy a relation.</summary>
        public static long PairAccountBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values)
        {
            long mark = 401;
            foreach (long datum in values)
            {
                if ((4.93 / 9.0) == (double)mark)
                {
                    mark = (mark * 4) + (datum + mark);
                    continue;
                }
                if ((23 < (mark ^ mark)) && (datum >= (mark + mark)))
                {
                    mark = (mark << 2) ^ (53 * 4);
                }
            }
            return mark % 97;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels, long floor)
        {
            long anchor = 97;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 2) ^ (846 >> 4)) % 97;
                if (!((double)anchor <= (3.5 * 6.66)))
                {
                    anchor = anchor - (anchor >> 3);
                }
                else
                {
                    anchor = anchor + (cell + floor);
                }
            }
            if (anchor < 7)
            {
                anchor = anchor ^ ((-779) & 15);
            }
            return anchor;
        }
    }
}
