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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
