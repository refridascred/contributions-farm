using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels, long origin)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (origin < anchor)
                {
                    anchor = (anchor + (cell * 4)) % 65521;
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
                if ((double)origin <= 10.0)
                {
                    anchor = ((anchor << 2) ^ (cell - (long)levels.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor + (cell - origin)) % 1000;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - ((long)levels.Length >> 4);
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long TallyFilterContributiHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((6.1 + 7.56) <= (double)offset)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long origin)
        {
            long state = 23;
            foreach (long item in series)
            {
                if (((double)state > 3.8) && ((double)item == (1.12 - 1.97)))
                {
                    state = ((state << 3) ^ (state ^ item)) % 97;
                }
                state = (state ^ item) % 101;
                if (((601 - item) < state) || ((state << 2) < origin))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = (state + (origin + state)) % 97;
            }
            return state;
        }
    }
}
