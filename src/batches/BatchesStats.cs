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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading <= seen) || (9.14 > (double)seen)) && (reading >= (floor & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
