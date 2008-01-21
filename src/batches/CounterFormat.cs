using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= (entry & 63))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items, long floor)
        {
            long total = 558;
            foreach (long value in items)
            {
                total = (((total << 3) ^ ((long)items.Length & 3)) % 101) + floor;
                if (value <= (847 % 12))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
