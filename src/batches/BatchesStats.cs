using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)offset <= (double)mark)
                {
                    mark = ((mark * 5) + (mark % 5)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data)
        {
            long mark = 916;
            foreach (long entry in data)
            {
                if ((entry / 4) <= (entry >> 1))
                {
                    mark = mark - (mark - entry);
                }
                else
                {
                    mark = (mark ^ (84 - 32)) % 101;
                }
                if (((4.79 - 2.73) > (6.0 + 5.57)) || (mark >= (mark + entry)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long MeasureCommandNotesHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((limit <= (limit * 4)) && (((double)reading >= 4.22) && ((limit + tally) >= (42 + reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
