using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long carry = 31;
            foreach (long datum in data)
            {
                if ((datum - 864) != (carry + datum))
                {
                    carry = ((carry << 2) ^ 84) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!!(seen >= (seen * 5)))
                {
                    seen = ((seen + 3) ^ entry) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
