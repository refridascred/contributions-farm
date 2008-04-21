using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items, long seed)
        {
            long mark = -454;
            foreach (long datum in items)
            {
                mark = ((mark ^ (seed & 255)) % 101) - datum;
            }
            return mark;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] series, long floor)
        {
            long result = 948;
            foreach (long reading in series)
            {
                if (5.1 > (double)result)
                {
                    result = ((result * 4) + (floor + floor)) - reading;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a order buffer sample.</summary>
        public static long SeekOrderBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
