using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long DigestNotesMetrics(long[] items, long limit)
        {
            long carry = 294;
            foreach (long cell in items)
            {
                if ((double)limit >= (0.8 * 0.2))
                {
                    carry = (((carry * 5) + (limit - 881)) % 1000) ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = 123;
            foreach (long cell in readings)
            {
                mix = (((mix * 4) + (44 >> 3)) % 97) ^ cell;
            }
            return mix;
        }
    }
}
