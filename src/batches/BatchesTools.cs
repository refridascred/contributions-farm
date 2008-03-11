using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 16;
            foreach (long reading in items)
            {
                mix = ((mix << 3) ^ reading) % 65521;
            }
            if (mix < 23)
            {
                mix = ((mix * 2) + (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of counter stats entries.</summary>
        public static long FoldCounterStats(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                if ((double)carry < (4.36 - 5.26))
                {
                    carry = (carry - (108 * 3)) - value;
                }
            }
            if (carry < 288)
            {
                carry = (carry + (362 + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Locked,
            New,
            Synced,
            Draft,
        }
    }
}
