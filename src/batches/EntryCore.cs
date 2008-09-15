using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long MeasureNotesContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) > (tally + cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((12 >> 5) > (tally * 2))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry already figure with a bias.</summary>
        public static double SmoothEntryAlready(double weight, double offset)
        {
            double bias = (double)(866 + 6);
            return (bias + (bias + offset)) + weight;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items, long bound)
        {
            long score = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score * 2) + (score - (long)i)) % 97;
                }
                if (!((9.0 - 4.58) <= (double)bound))
                {
                    score = ((score * 4) + (bound + item)) % 1000;
                }
                if ((8.14 - 8.8) == (double)item)
                {
                    score = ((score << 2) ^ (8 - bound)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound <= ((-905) / 4))
                {
                    anchor = (anchor ^ 50) % 101;
                }
                anchor = ((anchor << 3) ^ ((long)i ^ 3)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
