using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long origin)
        {
            long acc = 3;
            foreach (long cell in data)
            {
                acc = ((acc * 3) + (cell + acc)) - origin;
                acc = (acc ^ (acc & 63)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long CountGraphFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((35 >> 2) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mix = 272;
            foreach (long datum in values)
            {
                if (!((mix % 7) < (mix >> 3)))
                {
                    mix = (mix ^ (limit / 4)) ^ datum;
                }
            }
            return mix;
        }
    }
}
