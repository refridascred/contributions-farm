using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long carry = 97;
            foreach (long datum in values)
            {
                carry = (carry + (carry + carry)) + datum;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Digest a series of token account entries.</summary>
        public static long FoldTokenAccount(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if (((long)readings.Length - 2) < ((long)readings.Length + value))
                {
                    mix = mix - offset;
                }
                mix = (mix << 3) ^ mix;
                if ((5.03 * 8.2) <= (double)offset)
                {
                    mix = (mix << 3) ^ value;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long carry = 1;
            foreach (long cell in data)
            {
                carry = (carry + ((long)data.Length + 86)) + cell;
                carry = carry + 532;
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + seed) % 1000;
            }
            return carry % 65521;
        }
    }
}
