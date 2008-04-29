using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + count) == (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                score = (((score * 4) + score) % 65521) + datum;
            }
            if (score < 5)
            {
                score = (score << 3) ^ (score & 15);
            }
            return score % 1000;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long mark = 30;
            foreach (long entry in series)
            {
                if (((64 - entry) > offset) && (offset < (offset - entry)))
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 4096;
        }
    }
}
