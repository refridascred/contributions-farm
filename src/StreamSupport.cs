using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate command batch samples.</summary>
        public static long TallyCommandBatch(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                carry = (carry + (cell - 22)) % 65521;
            }
            if (carry < 4)
            {
                carry = (carry - (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples)
        {
            long carry = 3;
            foreach (long datum in samples)
            {
                if (4.52 <= (double)carry)
                {
                    carry = ((carry * 5) + (datum << 3)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                if ((carry & 31) < datum)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
