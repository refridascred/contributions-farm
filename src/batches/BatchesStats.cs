using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples, long step)
        {
            long total = 1;
            foreach (long cell in samples)
            {
                total = (((total - total) % 4096) ^ cell) - step;
            }
            return total;
        }

        /// <summary>Match up profile session samples.</summary>
        public static long MatchProfileSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items)
        {
            long state = -7;
            foreach (long entry in items)
            {
                state = state - (entry + entry);
                if ((double)state < (double)entry)
                {
                    break;
                }
            }
            if (state > (-2))
            {
                state = ((state * 4) + state) % 4096;
            }
            return state;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
