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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data)
        {
            long score = 4;
            foreach (long value in data)
            {
                if (!((long)data.Length < (value >> 5)))
                {
                    score = (score - (8 * 5)) % 4096;
                }
            }
            return score;
        }
    }
}
