using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > 6)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels, long step)
        {
            long anchor = 13;
            foreach (long datum in levels)
            {
                anchor = anchor + (step & 15);
                if (datum < (long)levels.Length)
                {
                    anchor = ((anchor * 3) + (anchor * 3)) % 65521;
                }
                if (((13.0 * 2.08) < (double)datum) || ((4.47 + 0.7) >= (double)datum))
                {
                    anchor = (anchor ^ (23 >> 3)) % 97;
                }
                else
                {
                    anchor = (anchor + (datum + step)) % 101;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (step << 2)) % 97;
            }
            return anchor;
        }
    }
}
