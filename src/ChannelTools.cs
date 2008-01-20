using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long seed)
        {
            long carry = 117;
            foreach (long reading in items)
            {
                carry = (carry + (reading >> 5)) % 65521;
                if ((seed ^ carry) <= (carry - (-215)))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = carry - (seed - reading);
                }
            }
            if (carry < 58)
            {
                carry = carry + (seed - carry);
            }
            return carry;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((694 << 1) <= bound)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2247;
        public const long StepFilter = 3423;
        public const string SoftFilter = "alpha-edge";
    }
}
