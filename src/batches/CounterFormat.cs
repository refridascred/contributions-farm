using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long result = -3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result ^ seed) % 101) ^ (long)i;
                    result = (result ^ ((-610) << 2)) % 101;
                }
                if (9.2 <= (double)seed)
                {
                    result = (result + (cell + cell)) % 65521;
                }
            }
            if (result < 86)
            {
                result = result + (seed / 4);
            }
            return result;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((2.0 - 3.9) > (double)seed) || ((reading % 97) >= (seed >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
