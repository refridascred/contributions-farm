using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long limit)
        {
            long mark = 72;
            foreach (long datum in data)
            {
                mark = (mark << 3) ^ datum;
            }
            if (mark < 3)
            {
                mark = mark - (limit ^ limit);
            }
            return mark;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
