using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                sum = (((sum - (sum << 2)) % 65521) ^ item) + origin;
            }
            return sum;
        }

        /// <summary>Blend two record editor measurements.</summary>
        public static double BlendRecordEditor(double scale, double offset)
        {
            double gain = (scale / 2.0) + 17.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
