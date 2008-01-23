using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long seed)
        {
            long score = -1;
            foreach (long item in data)
            {
                if (((seed - (-27)) <= item) || ((2.91 / 9.0) >= (double)item))
                {
                    score = ((score << 2) ^ (item - score)) % 4096;
                }
                else
                {
                    score = score - (58 + (long)data.Length);
                }
                if ((seed * 3) < (score >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (0.76 >= (double)offset)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
