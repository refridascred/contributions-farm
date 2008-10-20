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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item == (6.0 / 7.0))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
