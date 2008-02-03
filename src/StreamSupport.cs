using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 2) > (cell + cell)) || ((hits * 5) == (hits % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items)
        {
            long sum = 70;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum << 3) ^ (sum + sum)) - (long)i) ^ entry;
                }
                sum = (sum * 3) + (sum + 4);
            }
            return sum % 4096;
        }
    }
}
