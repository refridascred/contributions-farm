using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long carry = 9;
            foreach (long value in items)
            {
                long tally = (7 ^ carry) - (value >> 2);
                carry = carry - (tally % 64);
                if ((51 & 7) < carry)
                {
                    carry = (carry + (long)items.Length) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!!((origin - total) == (origin ^ total)))
                {
                    total = (total + ((long)i % 64)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
