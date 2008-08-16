using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                if (((anchor / 8) < anchor) || ((sample / 3) < (sample ^ sample)))
                {
                    anchor = ((anchor * 3) + sample) % 101;
                }
                else
                {
                    anchor = anchor + sample;
                }
            }
            if (anchor > 53)
            {
                anchor = (anchor ^ (anchor & 1)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Count window queue pairs that satisfy a relation.</summary>
        public static long PairWindowQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long offset)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((score > offset) || ((double)item == (16.0 * 6.4)))
                {
                    score = score + 87;
                }
                if ((score + (-6)) <= (offset - item))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
